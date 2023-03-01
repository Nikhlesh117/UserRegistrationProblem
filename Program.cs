using System.ComponentModel.DataAnnotations;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Welcome to the User Registration Problem\n");

            Console.WriteLine("1. Enter valid First Name");
            Console.WriteLine("2. Enter valid Last Name");
            Console.WriteLine("3. Enter valid email");
            Console.WriteLine("4. Enter Mobile number along with country code");
            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Validate validate = new Validate();
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Your First Name : ");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine(validate.FirstName(FirstName));
                    break;
                case 2:
                    Console.Write("Enter Your Last Name : ");
                    string LastName = Console.ReadLine();
                    Console.WriteLine(validate.LastName(LastName));
                    break;
                case 3:
                    Console.Write("Enter Your Email : ");
                    string email = Console.ReadLine();
                    Console.WriteLine(validate.Email(email));
                    break;
                case 4:
                    Console.Write("Enter Your Phone Number : ");
                    string PhoneNumber = Console.ReadLine();
                    Console.WriteLine(validate.Mobile(PhoneNumber));
                    break;

                default:
                    Console.WriteLine("Please enter correct choice");
                    break;

            }
        }
    }
}