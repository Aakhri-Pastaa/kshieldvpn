# KShieldVPN

> A Windows desktop VPN client built as a final year project for BSc Computer Science (Hons.) at Somaiya Vidyavihar University. Wraps OpenVPN with a custom C# interface, SQL Server authentication, Stripe payment integration, and built-in diagnostic tools.

![Status](https://img.shields.io/badge/Status-Completed%20%2F%20Archived-lightgrey)
![Platform](https://img.shields.io/badge/Platform-Windows-0078D4?logo=windows)
![Language](https://img.shields.io/badge/Language-C%23-purple?logo=csharp)
![Framework](https://img.shields.io/badge/UI-Guna2%20WinForms-blue)
![Academic](https://img.shields.io/badge/Academic-Final%20Year%20Project-darkgreen)

---

## What This Is

KShieldVPN is a fully functional VPN client application built on Windows Forms using C# and the Guna2 UI library. It wraps the OpenVPN engine behind a clean desktop interface, adding user authentication, a freemium access model, connection diagnostics, and a Stripe-integrated payment flow.

The project was submitted as a final year dissertation for BSc Computer Science (Hons.) at S.K. Somaiya College, Somaiya Vidyavihar University, Mumbai, in April 2024.

**Guide:** Mr. Shrinivas Acharya, Department of IT and Computer Science  
**Mentor:** Dr. Sunita Yadav, PhD in Blockchain Technology  
**Full project report:** [`docs/KShieldVPN_Project_Report.pdf`](docs/KShieldVPN_Project_Report.pdf)

---

## What It Does

Most VPN clients are either commercial black boxes or raw OpenVPN configs with no user experience around them. This project sits in between — it takes the OpenVPN engine and builds a complete user-facing application around it, with authentication, diagnostics, and subscription management.

The core idea was to understand what it actually takes to ship a privacy tool: not just the encryption, but the user management, the payment flow, the session handling, and the edge cases that come up when you try to make it work reliably.

---

## Features

**Authentication**
- User registration with SHA-256 hashed passwords stored in SQL Server
- Login with session management and "Remember Me" support
- Forgot password via email reset flow

**VPN Core**
- Server selection (Seoul, Paris, and others) via dropdown
- One-click connect/disconnect
- OpenVPN invoked via system command with `.ovpn` config + `cred.txt`
- Disconnection handled via `taskkill` on `openvpn.exe`

**Diagnostics**
- Speed test module — measures ping, download, and upload
- DNS leak test module — verifies DNS queries are routed through the VPN tunnel

**Access Control**
- Free vs. premium user tiers enforced via `IsPremium` boolean in database
- Premium upgrade via Stripe Checkout (demo/sandbox mode)
- Session flags passed through `SessionManager` class across all forms

## A Note on Repository Structure

The file structure in this repository has been reorganized for visual clarity 
and GitHub presentation. The original unmodified project files are preserved 
in `OG FS/` as a compressed archive for anyone who wants to test or recreate 
the project exactly as it was built in Visual Studio.
---

## Architecture

```
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

---

## Database Design

Intentionally minimal. A single `Users` table with three fields:

| Field | Type | Purpose |
|---|---|---|
| `Email` | varchar(255) PK | Unique user identifier |
| `PasswordHash` | varchar(255) | SHA-256 hashed password |
| `IsPremium` | boolean | Free vs. premium access gate |

This covers login validation, session checks, and premium access control with straightforward parameterized queries — no unnecessary complexity for a demo-scale project.

---

## Tech Stack

| Layer | Technology |
|---|---|
| UI | C# Windows Forms + Guna2 UI library |
| Backend | C# (.NET Framework 4.8+) |
| Database | Microsoft SQL Server (SSMS) |
| VPN Engine | OpenVPN (invoked via system process) |
| Cloud / VPN Server | AWS EC2 |
| Payment | Stripe Checkout (sandbox) |
| Version Control | Git |

---

## Key Implementation Details

### Password Hashing
Registration hashes passwords with SHA-256 before storing. Login hashes the input and compares — the plaintext password never touches the database. The `VerifyPassword` method handles comparison.

### OpenVPN Integration
Server connection is handled by launching `openvpn.exe` as a background process, passing the `.ovpn` config file and `cred.txt` as arguments:

```csharp
Process.Start("openvpn.exe", $"--config {configPath} --auth-user-pass {credPath}");
```

Disconnection terminates the process:

```cmd
taskkill /F /IM openvpn.exe
```

### Session Management
A `SessionManager` static class carries `UserEmail` and `IsPremiumUser` flags between forms. On logout, both are cleared and the app returns to the login screen.

### Stripe Integration
The premium upgrade opens a browser-based Stripe Checkout session. Post-payment, the `IsPremium` flag is updated in the database. The demo uses sandbox mode — no real charges.

---

## Security Considerations (Honest Assessment)

The project report's security section documents known limitations rather than glossing over them. These were acknowledged as part of the academic evaluation:

- **No kill switch** — if the VPN drops unexpectedly, traffic reverts to the unencrypted connection without user notification
- **Credential file exposure** — `cred.txt` is a plaintext file on disk; OS-level file permissions mitigate this but don't eliminate the risk
- **Demo payment flow** — Stripe webhook verification is not implemented, so the premium flag could be set without genuine payment confirmation in a test scenario
- **No DNS leak prevention** — the DNS Leak Test module identifies leaks but does not actively prevent them; users must configure DNS manually

These would be addressed in any production iteration.

---

## Testing

The project includes a full test suite documented in the project report:

- **General test cases** (TC_001–TC_010) — input validation, session expiry, access control
- **Unit tests** (TC_U001–TC_U020) — authentication logic, hash functions, VPN process management, session flags
- **Integration tests** (TC_I001–TC_I014) — form transitions, OpenVPN config loading, Stripe flow, session propagation
- **System tests** (TC_S001–TC_S012) — end-to-end user journeys, premium access restriction, navigation

---

## Development Timeline

| Phase | Dates |
|---|---|
| Requirements + Synopsis | Jan 4–11, 2024 |
| System Design | Jan 12–Feb 2, 2024 |
| Conceptual Models | Feb 2–16, 2024 |
| Coding | Feb 16–Mar 25, 2024 |
| Testing + Documentation | Mar 27–Apr 18, 2024 |
| Submission | Apr 23, 2024 |

---

## Repository Structure

```
kshieldvpn/
├── src/
│   ├── KShieldVPN/              # Main Windows Forms project
│   │   ├── LoginForm.cs
│   │   ├── Kshieldvpn1.cs       # Main dashboard
│   │   ├── stform.cs            # Speed test form
│   │   ├── dnsleakform.cs       # DNS leak test form
│   │   └── SessionManager.cs
│   └── KShieldVPN.sln
├── configs/
│   └── *.ovpn                   # OpenVPN server configs
├── docs/
│   └── KShieldVPN_Project_Report.pdf
└── README.md
```

---

## Requirements

**To run:**
- Windows 10 or later
- .NET Framework 4.8+
- OpenVPN installed on the host system
- SQL Server (local or remote) with the `Users` table set up
- Valid `.ovpn` config files for each server

**To develop:**
- Visual Studio 2019/2022
- Guna2 UI library (NuGet)
- SQL Server Management Studio (SSMS)

---

## Limitations and What Comes Next

This was a scoped academic project, not a production tool. The architecture is intentionally simple — a three-field database, manual server configs, demo payment flow. It demonstrates the full lifecycle of a privacy application (auth, connectivity, diagnostics, monetization) in a working but bounded form.

A real-world version would need: WireGuard support alongside OpenVPN, webhook-verified payments, a proper kill switch, multi-platform builds, and DNS-over-HTTPS. The project report's future scope section covers this in detail.

---

## Academic Context

This project was formally examined and approved at S.K. Somaiya College, Somaiya Vidyavihar University (2022–25 batch) as a final year BSc dissertation requirement.

---

## Tech Stack Summary

`C#` · `.NET Framework` · `Windows Forms` · `Guna2 UI` · `OpenVPN` · `SQL Server` · `AWS` · `Stripe` · `SHA-256` · `Git`

---

## Author

**Kunal Ravindra Patil** — BSc Computer Science (Hons.), Somaiya Vidyavihar University  
[LinkedIn](https://linkedin.com/in/kunal-patil-0b4713276) · [GitHub](https://github.com/Aakhri-Pastaa)
