using System;

namespace loginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "admin";
            string password = "pass1234";
            int try1 = 3;

            string userName, userPass;

            while (try1 != 0)
            {
                Console.WriteLine("Enter your username: ");
                userName = Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                userPass = Console.ReadLine();
                try1-=1;
                if(login == userName && password == userPass)
                {
                    Console.WriteLine("Welcome!");
                }
                else if(try1>0)
                {
                    Console.WriteLine($"More {try1} tries!");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Oops. Something went wrong!");
        }
    }
}
