using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage
{
    interface IBuild
    {
        void Add();
        void View();       
    }
    class Student : IBuild
    {
        private string fID;
        private int lID;
        private string stname;
        private string dob;
        private string email;
        private string address;
        private string batch;

        public string FID { get => fID; set => fID = value; }
        public int LID { get => lID; set => lID = value; }
        public string Stname { get => stname; set => stname = value; }
        public string DoB { get => dob; set => dob = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Batch { get => batch; set => batch = value; }        
        bool flag;
        
        public void Add()
        {
            flag = true;
            do
            {
                Console.WriteLine("Enter student's first ID (GT or GC):");
                fID = Console.ReadLine();
                if(fID == "GT" || fID == "GC")
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("First ID fail, enter again");
                    flag = false;
                }

                if(flag == true)
                {
                    try
                    {
                        Console.WriteLine("Enter student's last ID (5 digits):");
                        lID = int.Parse(Console.ReadLine());
                        flag = true;
                    }
                    catch
                    {
                        Console.WriteLine("last ID must be a number, please enter again");
                        flag = false;
                    }
                }                
                if (flag == true)
                {
                    if (lID >= 10000 && lID <= 99999)
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("last ID must have 5 digits, please enter again");
                        flag = false;
                    }
                }
                
                if(flag == true)
                {
                    Console.WriteLine("Enter student's name:");
                    stname = Console.ReadLine();
                    Console.WriteLine("Enter date of birth:");
                    dob = Console.ReadLine();
                    Console.WriteLine("Enter email:");
                    email = Console.ReadLine();
                    Console.WriteLine("Enter adress:");
                    address = Console.ReadLine();
                    Console.WriteLine("Enter batch:");
                    batch = Console.ReadLine();
                    
                }
            } while (flag == false);           
        }

        public void View()
        {
            Console.WriteLine("");
            Console.WriteLine("ID: {0}{1} || Name: {2} || Date of birth: {3} || Email: {4} || Adress: {5} || Batch: {6}", fID, lID, stname, dob,email, address, batch);
        }                        
    }

    class Teacher : IBuild
    {        
        private int id;
        private string name;
        private string dob;
        private string email;
        private string address;
        private string dept;
        
        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string DoB { get => dob; set => dob = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Dept { get => dept; set => dept = value; }
        bool flag;

        public void Add()
        {
            flag = true;
            do
            {
                
                try
                {
                    Console.WriteLine("Enter teacher's ID:");
                    id = int.Parse(Console.ReadLine());
                    flag = true;
                }
                catch
                {
                    Console.WriteLine("ID must be a number, please enter again");
                    flag = false;
                }

                if (flag == true)
                {
                    if (id >= 10000000 && id <= 99999999)
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("ID must have 8 digits, please enter again");
                        flag = false;
                    }
                }
                
                

                if(flag == true)
                {
                    Console.WriteLine("Enter date of birth:");
                    dob = Console.ReadLine();
                    Console.WriteLine("Enter email:");
                    email = Console.ReadLine();
                    Console.WriteLine("Enter adress:");
                    address = Console.ReadLine();
                    Console.WriteLine("Enter department:");
                    dept = Console.ReadLine();
                    Console.WriteLine("Add successfully:");
                }
            } while (flag == false);
        }
        public void View()
        {
            Console.WriteLine("ID: {0} || Name: {1} || Date of birth: {2} || Adress: {3} || Batch: {4}", id, name, dob, address, dept);
        }
    }

    class Function
    {
        public void Exit(int n)
        {
            Console.WriteLine("Do you want to exit: 1.Yes or 2.No");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Environment.Exit(n = 5);
            }
            else
            {
                Console.WriteLine("Continue.");
            }
        }
    }
}
    
