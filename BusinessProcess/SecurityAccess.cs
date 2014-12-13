using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JentrousMarketing.BusinessProcess
{
    public static class SecurityAccess
    {
        private static bool isAdmin = false;

        public static bool IsAdmin
        {
            get { return SecurityAccess.isAdmin; }
        }

        private static bool isManager = false;
        public static bool IsManager
        {
            get { return SecurityAccess.isManager; }
        }

        private static bool isEmployee = false;
        public static bool IsEmployee
        {
            get { return SecurityAccess.isEmployee; }
        }

        private static string role;
        public static string Role
        {
            set
            {
                SecurityAccess.role = value;

                if (RolesEnum.Administrator.ToString() == role)
                {
                    SecurityAccess.isAdmin = true;
                }
                else if (RolesEnum.Manager.ToString() == role)
                {
                    SecurityAccess.isManager = true;
                }
                else
                {
                    SecurityAccess.isEmployee = true;
                }
            }

        }
    }
}
