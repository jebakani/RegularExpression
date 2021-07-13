using System;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EmailValidity email = new EmailValidity();
            email.EmailCheck();
            Console.Read();
        }
    }
}
