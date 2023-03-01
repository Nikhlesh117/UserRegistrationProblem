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
        public const string Regex_PhoneNumber = "[+][1-9]{1,2}[ ][0-9]{10}$";

        public const string Regex_PasswordR1 = "^[A-Za-z0-9]{8,15}$";
        public const string Regex_PasswordR2 = "^(?=.*[A-Z]).{8,}$";

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
        public bool Mobile(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, Regex_PhoneNumber);
        }
        public bool PasswordR1(string password)
        {
            return Regex.IsMatch(password, Regex_PasswordR1);
        }
        public bool PasswordR2(string password2)
        {
            return Regex.IsMatch(password2, Regex_PasswordR2);
        }
    }
}
