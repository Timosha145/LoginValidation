using System;

namespace loginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "admin";
            string password = "pass1234";

            string userName, userPass;

            Console.WriteLine("Enter your username: ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            userPass = Console.ReadLine();

            if(login == userName && password == userPass)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Oops. Something went wrong!");
            }
        }
    }
}
