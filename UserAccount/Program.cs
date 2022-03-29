using System;
using UserAccount.Models;
namespace UserAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                User user = new User();
                Console.Write("Enter your full name: ");
                user.FullName = Console.ReadLine();

                Console.Write("Enter your email: ");
                user.Email = Console.ReadLine();

                Console.Write("Enter your password: ");
                user.Password = Console.ReadLine();

                Console.WriteLine("Press any key to continue");
                Console.WriteLine("Press ESC to quit the app");
            } while (Console.ReadKey().Key !=ConsoleKey.Escape);
        }
    }
}