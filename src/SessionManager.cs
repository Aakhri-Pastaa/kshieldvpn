using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KshieldVPN
{
    public static class SessionManager
    {
        public static string Email { get; set; }
        public static bool IsPremium { get; set; }
        public static bool IsLoggedIn { get; set; }

        public static void ClearSession()
        {
            Email = null;
            IsPremium = false;
            IsLoggedIn = false; // Reset login status
        }
    }
}
