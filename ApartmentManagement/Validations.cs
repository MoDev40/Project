using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManagement
{
    class Validations
    {
        public static bool ValidateEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            // Create a regular expression object
            Regex regex = new Regex(pattern);

            // Match the email address against the pattern
            Match match = regex.Match(email);

            // Return true if the email address is valid, false otherwise
            return match.Success;
        }

        public static bool IsNumeric(string value){

            string pattern = @"^\d+$";

            Regex regex = new Regex(pattern);

            Match match= regex.Match(value);

            return match.Success;
        }

        public static bool ValidatePassword(string password)
        {
            // Regular expression pattern for password validation
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z0-9]{1,}$";

            // Create a regular expression object
            Regex regex = new Regex(pattern);

            // Match the password against the pattern
            Match match = regex.Match(password);

            // Return true if the password is valid, false otherwise
            return match.Success;
        }

        public static bool IsInteger(string input) => int.TryParse(input, out _);
        public static bool IsDouble(string input)=> double.TryParse(input, out _);
        public static bool IsNull(string input) => string.IsNullOrWhiteSpace(input);
        public static bool IsDecimal(string input) => decimal.TryParse(input, out _);




    }
}
