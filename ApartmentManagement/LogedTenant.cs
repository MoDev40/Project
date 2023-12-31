using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement
{
     class LogedTenant
    {
        private static int tenantID;
        private static string tenantName;

        private static string email;

        public static int TenantID { get { return tenantID; } set { tenantID = value; } }

        public static string TenantName { get {  return tenantName; } set { tenantName = value; } }

        public static string Email { get { return email; } set {  email = value; } }
    }
}
