# KShieldVPN

**A Windows desktop VPN client in C# (.NET Framework 4.7.2, Windows Forms with the Guna2 UI library) that drives the OpenVPN engine as a child process and adds SQL Server–backed accounts, a free/premium tier with Stripe Checkout in sandbox mode, and speed and DNS/IP diagnostics.**

> [!NOTE]
> **Status: final-year BSc project, submitted April 2024, archived and not maintained.** It is a scoped academic prototype, not a production VPN — see [Status and limitations](#status-and-limitations) for the known security gaps.
> Built by Kunal Patil, with AI assistance on specific parts. See [AI disclosure](#ai-disclosure).

## What it does

KShieldVPN wraps OpenVPN behind a desktop interface. A user registers or
logs in against a SQL Server `Users` table, picks a server (Seoul, Paris and
others) from a dropdown, and connects with one click; the client launches
`openvpn.exe` with the server's `.ovpn` profile and a credentials file, and
disconnects by terminating that process. Premium servers are gated by an
`IsPremium` flag, and upgrading opens a Stripe Checkout page.

Most VPN clients are either commercial black boxes or raw OpenVPN configs
with no user experience around them. I wanted to understand what it takes to
ship a privacy tool: not just the encryption, but the user management, the
payment flow, the session handling, and the edge cases that come up when you
try to make it work reliably.

## Academic context

Submitted as the final-year dissertation for BSc Computer Science (Hons.) at
S.K. Somaiya College, Somaiya Vidyavihar University, Mumbai (2022–25 batch),
in April 2024, and formally examined and approved.

- **Guide:** Mr. Shrinivas Acharya, Department of IT and Computer Science
- **Mentor:** Dr. Sunita Yadav, PhD in Blockchain Technology
- **Full project report:** [`docs/VPN Documentation KRP.pdf`](<docs/VPN Documentation KRP.pdf>)

| Phase | Dates |
|---|---|
| Requirements + synopsis | Jan 4–11, 2024 |
| System design | Jan 12–Feb 2, 2024 |
| Conceptual models | Feb 2–16, 2024 |
| Coding | Feb 16–Mar 25, 2024 |
| Testing + documentation | Mar 27–Apr 18, 2024 |
| Submission | Apr 23, 2024 |

## How it works

```text
┌──────────────────────────────────────┐
│         Guna2 Windows Forms UI        │
│  Login → Dashboard → Test Forms       │
└─────────────────┬────────────────────┘
                  │ C# backend logic
┌─────────────────▼────────────────────┐
│         Business Logic Layer          │
│  Auth · Session · VPN Process Mgmt   │
└──────┬──────────────────┬────────────┘
       │                  │
┌──────▼──────┐   ┌───────▼──────────┐
│  SQL Server  │   │   OpenVPN CLI    │
│  (Users DB)  │   │  (.ovpn + creds) │
└─────────────┘   └──────────────────┘
                           │
                  ┌────────▼────────┐
                  │   AWS VPN Server │
                  │  (remote exit)   │
                  └─────────────────┘
```

**Accounts.** Registration (`Form2.cs`) hashes the password with SHA-256 and
inserts the email and hash into `Users`. Login (`Login_Form.cs`) reads the
stored hash with a parameterized query (`@Email`) and compares it with the
hash of the entered password in `VerifyPassword`, so the plaintext never
reaches the database. "Remember Me" is supported.

**Sessions.** A static `SessionManager` class carries `Email`, `IsPremium`
and `IsLoggedIn` across forms; `ClearSession()` resets them on logout and the
app returns to the login screen.

**VPN process.** Connecting starts `openvpn.exe` through a hidden
`ProcessStartInfo`:

```csharp
string arguments = $"--config \"{configFilePath}\" --auth-user-pass \"{authScriptPath}\"";
```

Disconnecting runs `taskkill /f /im openvpn.exe`.

**Premium tier.** `IsPremium` gates the premium servers. The upgrade button
asks a local ASP.NET web API (`https://localhost:44359`) to create a Stripe
Checkout session and opens it in the browser; after payment, the API sets
the flag in the database. Stripe runs in sandbox mode — no real charges. The
forgot-password form posts the email to the same local API, which sends the
reset link. That web API is not part of this repository.

**Diagnostics.** The speed test (`stform.cs`) measures ping, download and
upload against `speed.cloudflare.com`. The DNS/IP check (`dnsleakform.cs`)
resolves a set of test domains, then looks up the public IP
(`api.ipify.org`) and its organisation (`ipapi.co`) and lists them.

**Database.** Intentionally minimal — one `Users` table (schema from the
project report; no schema script is included):

| Field | Type | Purpose |
|---|---|---|
| `Email` | varchar(255) PK | Unique user identifier |
| `Password` | varchar(255) | SHA-256 hash of the password |
| `IsPremium` | boolean | Free vs. premium access gate |

## Testing

The test cases are documented in the project report; there is no automated
test project in this repository.

- **General test cases** (TC_001–TC_010) — input validation, session expiry, access control
- **Unit tests** (TC_U001–TC_U020) — authentication logic, hash functions, VPN process management, session flags
- **Integration tests** (TC_I001–TC_I014) — form transitions, OpenVPN config loading, Stripe flow, session propagation
- **System tests** (TC_S001–TC_S012) — end-to-end user journeys, premium access restriction, navigation

## Status and limitations

Status as submitted in April 2024:

| Area | Status | Notes |
|---|---|---|
| Login, registration, sessions | Works | Against a local SQL Server with the `Users` table |
| Connect / disconnect | Works | Launches and kills `openvpn.exe`; profiles in `bin/` |
| Speed test | Works | Against `speed.cloudflare.com` |
| Premium upgrade, password reset | Partial | Need the local web API, which is not in this repository |
| DNS leak detection | Partial | Shows the public IP's network, not the resolvers used |
| Kill switch, DNS leak prevention | Not built | See below |

The project report's security section documented these limitations as part
of the academic evaluation:

- **No kill switch** — if the VPN drops unexpectedly, traffic reverts to the unencrypted connection without notifying the user.
- **Credential file exposure** — the OpenVPN credentials file is plaintext on disk; OS file permissions mitigate this but do not eliminate the risk.
- **Demo payment flow** — Stripe webhook verification is not implemented, so the premium flag could be set without genuine payment confirmation in a test scenario.
- **No DNS leak prevention** — the DNS/IP check can flag a problem but does not prevent leaks; DNS must be configured manually.

Found in September 2026 while checking this README against the code:

- **SQL injection in registration.** `Form2.cs` builds the `INSERT` by string interpolation of the email field; login is parameterized, registration is not.
- **Unsalted SHA-256 for passwords.** Fast to brute-force if the table leaks; a production version would use a salted, slow key-derivation function (PBKDF2, bcrypt or Argon2).
- **The DNS/IP check cannot prove there is no leak.** It reports the public egress IP's organisation, not which resolvers answered the queries.
- **"Connected" is reported when the process starts**, not when the tunnel is up.
- **Hardcoded paths.** The `openvpn.exe` and credentials-file paths are absolute Windows paths in `Kshieldvpn1.cs`.

A real-world version would also need WireGuard alongside OpenVPN,
webhook-verified payments, multi-platform builds and DNS-over-HTTPS; the
project report's future-scope section covers this.

## Install and build

| Requirement | Version | Why |
|---|---|---|
| Windows | 10 or later | Windows Forms desktop app |
| .NET Framework | 4.7.2 | `TargetFrameworkVersion` in `src/KshieldVPN.csproj` |
| Visual Studio | 2019 or 2022 | Build the solution (`src/KshieldVPN.sln`) |
| SQL Server + SSMS | — | `Users` table |
| OpenVPN for Windows | — | The VPN engine the client launches |
| NuGet packages | Guna.UI2.WinForms 2.0.4.7, Stripe.net 48.0.0, SpeedTest.NetCore 2.1.0, Newtonsoft.Json 13.0.3 | UI, payments, speed test, JSON |

Open `src/KshieldVPN.sln` in Visual Studio, restore the NuGet packages, set
the connection string and the OpenVPN paths for your machine, and build. The
original, unmodified Visual Studio project is preserved in `OG FS/` as a
split 7-Zip archive for anyone who wants to rebuild it exactly as it was
submitted.

## Repository layout

The repository was reorganized for presentation; the original layout is the
archive in `OG FS/`.

```text
kshieldvpn/
├── src/
│   ├── KshieldVPN.sln, KshieldVPN.csproj
│   ├── Login_Form.cs            # login, password check, session start
│   ├── Form2.cs                 # registration
│   ├── ForgotPassword.cs        # reset request, sent to the local web API
│   ├── Kshieldvpn1.cs           # dashboard: servers, connect/disconnect, upgrade
│   ├── stform.cs                # speed test
│   ├── dnsleakform.cs           # DNS/IP check
│   ├── SessionManager.cs        # session flags shared across forms
│   ├── Program.cs
│   ├── Properties/              # App.config, packages.config, assembly info
│   └── Resources/               # images
├── bin/                         # OpenVPN binaries and client profiles
├── docs/VPN Documentation KRP.pdf   # full project report
└── OG FS/                       # original Visual Studio project (split .7z) + screenshot
```

## AI disclosure

I designed and built KShieldVPN: the idea, the architecture, the database
design, the application code and the project report are mine. AI assistants
helped with specific parts — debugging, individual code snippets and
drafting documentation. In September 2026 this README was restructured with
an AI assistant to match my documentation standard; it corrects details that
no longer matched the code (file names, the framework version, the password
column, the web-API dependency) and adds the findings listed under
[Status and limitations](#status-and-limitations).

## Built with

C# · .NET Framework 4.7.2 · Windows Forms · Guna2 UI · OpenVPN · SQL Server · AWS EC2 · Stripe · Newtonsoft.Json
