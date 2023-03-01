using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Validate
    {
        public static string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Regex_LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool FirstName(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_FirstName);
        }
        public bool LastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
    }
}
