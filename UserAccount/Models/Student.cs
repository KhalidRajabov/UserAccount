using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccount.Models
{
    internal class Student
    {
        private static int _id = 1;
        public int Id { get; }
        public string FullName { get; set; }
        public int Point { get; set; }
         //hardasa id toplanilmalidi
        public Student()
        {
            Id = _id;
        }
        public Student(string name, int point)
        {
            FullName = name;
            Point = point;
        }
        static void StudentInfo()
        {

        }

    }
}
