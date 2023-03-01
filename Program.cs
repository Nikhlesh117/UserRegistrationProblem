namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Welcome to the User Registration Problem\n");

            Console.WriteLine("1. Enter valid First Name");
            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Validate validate1 = new Validate();
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Your First Name : ");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine(validate1.ValidateFirstName(FirstName));
                    break;

                default:
                    Console.WriteLine("Please enter correct choice");
                    break;

            }
        }
    }
}