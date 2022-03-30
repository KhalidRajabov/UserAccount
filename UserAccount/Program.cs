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

                Student student = new Student();
                Console.Write("Write student name: ");
                student.WholeName = Console.ReadLine();

                Console.Write("Write student point: ");
                student.Point = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Press any key to continue");
                Console.WriteLine("Press ESC to quit the app");
                Console.WriteLine("Press 1 to clear the screen");
                int clear = Convert.ToInt32(Console.ReadLine());

                switch (clear)
                {
                    case 1: 
                        Console.Clear();
                        break;
                    default:
                        break;
                }


            } while (Console.ReadKey().Key !=ConsoleKey.Escape);
        }
    }
}