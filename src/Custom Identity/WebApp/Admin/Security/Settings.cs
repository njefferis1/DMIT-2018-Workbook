using System;
using System.Collections.Generic;
using static System.Configuration.ConfigurationManager;
using System.Linq;
using System.Web;

namespace WebApp.Admin.Security
{
    public static class Settings
    {
        #region Security roles
        //public static string AdminRole => ConfigurationManager.AppSettings["adminRole"]; // getter for a property
        public static string AdminRole => AppSettings["adminRole"]; //  changed to this when we changed the using statment
        /*
            The above is the same as typing:
            public static string AdminRole
            {
                get { return ConfigurstionManager.AppSettings["adminRole"]; }
            }
        */
        public static string UserRole => AppSettings["userRole"];

        public static IEnumerable<string> DefaultSecurityRoles => new List<string> { AdminRole, UserRole };
        #endregion

        #region startup users
        public static string AdminUserName => AppSettings["adminUserName"];
        public static string AdminPassword => AppSettings["adminPassword"];
        public static string AdminEmail => AppSettings["adminEmail"];
        public static string TempPassword => AppSettings["temporaryUserPassword"];
        #endregion
    }
}