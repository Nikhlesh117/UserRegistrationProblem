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
        public const string Regex_Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public bool FirstName(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_FirstName);
        }
        public bool LastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
        public bool Email(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
    }
}
