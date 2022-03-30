using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccount.Models
{
    internal class User:IAccount
    {
        private static int _id=1;
        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        private string _password;
        
        public string Password {
            get 
            {
             return _password;
            } 
            set
            {
                if (PasswordChecker(value)==true)
                {
                    _password = value;
                    _id++;


                    ShowInfo();

                    return;

                }
                Console.WriteLine("=================================================================================");
                Console.WriteLine("Password is wrong. Correct form: More than 8, 1 uppercase, 1 lowercase, 1 number");
                return;

            } 
        }


        public User()
        {
            
            Id= _id;
        }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public bool PasswordChecker(string password)
        {
            char[] pas = password.ToCharArray();
            bool pascheck = false;

            if (pas.Length >= 8)
            {
                for (int i = 0; i < pas.Length; i++)
                {
                    if (char.IsLower(pas[i]) == true)
                    {
                        for (int j = 0; j < pas.Length; j++)
                        {
                            if (char.IsUpper(pas[j]) == true)
                            {
                                for (int k = 0; k < pas.Length; k++)
                                {
                                    if (char.IsNumber(pas[k]) == true)
                                    {
                                        pascheck = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return pascheck;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\n"+
                $"User id is {Id} \n" +
                $"User full name: {FullName} \n" +
                $"User email: {Email} \n" +
                $"\n" +
                $"");
        }
    }

    interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
