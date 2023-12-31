using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManagement
{
     class LogedUser
    {

        private static int userID;

        private static string userName;

        private static string position;


        private static bool isLogin = false;
        private static bool isAdmin = false;

        public static bool IsLogin {  get { return isLogin; } set { isLogin = value; } }
        public static bool IsAdmin { get { return isAdmin; } set { isAdmin = value; } }

        public static string Position { get { return position; } set { position = value; } }
       
        public static int UserID { get { return userID; } set { userID = value; } }
        public static string UserName { get { return userName; } set { userName = value; } }
    }
}
