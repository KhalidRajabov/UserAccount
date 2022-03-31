using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccount.Models
{
    internal class Group
    {
        private string _groupno;
        private int _stdlimit;
        private Student[] students;
        public int StdLimit {
            get
            {
                return _stdlimit;
            }
            set
            {
                if (value > 1 && value < 18) // minimum valueni test meqsedli 1 yazmisham
                {
                    _stdlimit = value;
                    return;
                }
                else
                {
                    Console.WriteLine("Min student limit 5, max student limit 18");
                }
            }
        }
        public string GroupNo
        {
            get
            {
                return _groupno;
            }
            set
            {
                if (CheckGroupNo(value) == true)
                {
                    _groupno = value;
                    Console.WriteLine($"Your GroupNo: {GroupNo}");
                    return;
                }

            }
        }
        public Group(string groupno, int stdlimit)
        {
            students = new Student[0];
            GroupNo = groupno;
            StdLimit = stdlimit;
        }
        public void AddStudent(Student std){

            if (students.Length < StdLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = std;
                Console.WriteLine($"{std.WholeName} added to group: {GroupNo}.");
                return;
            }
        }
        public bool CheckGroupNo(string groupNo)
        {
            bool final=false;
            bool let = false;
            bool num = false;
            if (groupNo.Length==5)
            {
                for (int i = 0; i < 2; i++)
                {
                    let = false;
                    if (char.IsUpper(groupNo[i])==true)
                    {
                        let = true;

                    }
                    else
                    {
                        Console.WriteLine("First 2 letters of GroupNo must be in uppercase.");
                        break;
                    }
                }
                for (int i = 2; i < groupNo.Length; i++)
                {
                    num = false;
                    if (char.IsNumber(groupNo[i])==true)
                    {
                        num = true;
                    }
                    else
                    {
                        Console.WriteLine("GroupNo must have numbers in it.");
                        break;
                    }
                }
                if (let == true && num == true)
                {
                    final = true;
                }
                else if (num == false || let == false)
                {
                    final = false;
                }
            }
            else
            {
                Console.WriteLine("GroupNo must have 5 characters: 2 uppercase and 3 numbers");
            }
            return final;

        }

        public void GetStudent(int? id)
        {
            bool exist = false;
            foreach (Student std in students)
            {
                if (id == std.Ident)
                {
                    Console.WriteLine(std);
                    exist = true;
                    return;
                }
            }
            if (exist == false)
            {
                Console.WriteLine($"{id} could not be found in {GroupNo}");
            }
        }
        public void GetStudents()
        {
            foreach (Student std in students)
            {
                Console.WriteLine(std);
            }
        }
    }


}
