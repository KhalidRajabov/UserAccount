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
        public int StdLimit;
        public string GroupNo 
        { 
            get
            {
                return _groupno;
            } 
            set 
            {
                if (CheckGroupNo(value)==true)
                {
                    _groupno = value;
                    Console.WriteLine($"Your GroupNo: {GroupNo}");
                    return;
                }
                
            } 
        }
        public Group(string groupno,int stdlimit)
        {
            GroupNo=groupno;
            StdLimit=stdlimit;
        }

        Student [] Students = new Student[0];
        public void AddStudent(Student std)
        {
            Students[0] = std;
        }

        public bool CheckGroupNo(string groupNo)
        {
            bool final=false;
            bool let;
            bool num;
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
            }
            else
            {
                Console.WriteLine("GroupNo must have 5 characters: 2 uppercase and 3 numbers");
            }
           
            final=true;
            return final;

        }
    }


}
