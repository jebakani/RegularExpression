using System;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression");
            UserRegistration user = new UserRegistration();
            Console.WriteLine("User registration");
            Console.Write("enter first name:");
            string firstName = Console.ReadLine();
            Console.Write("First name ");
            user.CheckName(firstName);
            Console.Write("enter last name:");
            string lastName = Console.ReadLine();
            Console.Write("Last name ");
            user.CheckName(lastName);
            Console.Write("enter email:");
            string email = Console.ReadLine();
            user.EmailCheck(email);
        }
    }
}
