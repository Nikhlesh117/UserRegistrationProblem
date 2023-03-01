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
        public const string Regex_PasswordR3 = "^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        public const string Regex_PasswordR4 = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$";

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
        public bool PasswordR3(string password3)
        {
            return Regex.IsMatch(password3, Regex_PasswordR3);
        }
        public bool PasswordR4(string password4)
        {
            return Regex.IsMatch(password4, Regex_PasswordR4);
        }
        public void Test()
        {
            Validate validate = new Validate();
            Console.WriteLine("A. Valid Emails");
            string[] validEmails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            for (int i = 0; i < validEmails.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + validEmails[i] + " : " + validate.Email(validEmails[i]));
            }
            Console.WriteLine("\nB. Invalid Emails");
            string[] invalidEmails = { "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            for (int i = 0; i < invalidEmails.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + invalidEmails[i] + " : " + validate.Email(invalidEmails[i]));
            }
        }
    }
}
