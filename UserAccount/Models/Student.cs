using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccount.Models
{
    internal class Student
    {
        private static int _ident = 0;
        public int Ident { get; }
        public string WholeName { get; set; }
        private int _point;
        public int Point {
            get
            {
                return _point;
            }
            set 
            {
                if (value > 100 || value < 1)
                {
                    Console.WriteLine("Points can not be 0 or more than 100 or less than 0");
                    return;
                }
                else
                {
                    
                    _point = value;
                    _ident++; 
                    StudentInfo();
                    return;
                }
                
            }
        }
        public Student()
        {
            Ident = _ident;
        }
        public Student(string name, int point)
        {
            WholeName = name;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"\n"+
                $"Student Id number: {_ident} \n" +
                $"Student name: {WholeName}\n" +
                $"Studnet point: {Point} \n" +
                $"\n" +
                $"");
        }

    }
}
