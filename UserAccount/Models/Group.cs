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
        public int StdLimit{
            get
            {
                return _stdlimit;
            }
            set
            {
                if (value > 10 && value< 5)
                {
                    _stdlimit = value;
                    return;
                }
                else
                {
                    Console.WriteLine("Min student limit 5, max student limit 10");
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
        int i = 0;
        Student [] Students = new Student[0];
        public void AddStudent(Student std)
        {
            Students[i] = std;
            i++;

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
    }


}
