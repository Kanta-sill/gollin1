using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            List<Teacher> teacher = new List<Teacher>();
            int St;
            bool Flag;
            int n, n1, n2;
            while (Flag=true)
            {
                Console.WriteLine("Choose function:");
                Console.WriteLine("1. Manage Students");
                Console.WriteLine("2. Manage Lectures");
                Console.WriteLine("3. Exit");
                Console.Write("Your choice:");
                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        {
                            do
                            {
                                Flag = true;
                                Console.WriteLine("Choose function:");
                                Console.WriteLine("1. Add new student");
                                Console.WriteLine("2. View all students");
                                Console.WriteLine("3. Search students");
                                Console.WriteLine("4. Delete students");
                                Console.WriteLine("5. Update student");
                                Console.WriteLine("6. Back to main menu");
                                Console.Write("Your choice:");
                                n1 = int.Parse(Console.ReadLine());
                                switch (n1)
                                {
                                    case 1:
                                        {

                                            Console.WriteLine("Enter number of student:");
                                            do
                                            {
                                                St = Convert.ToInt32(Console.ReadLine());
                                                if (St <= 0)
                                                {
                                                    Console.WriteLine("Error! Number must greater than 0!");
                                                    Console.Write("Enter again:");
                                                }
                                                else break;
                                            } while (St > 0);                                            
                                            for (int i = 0; i < St; i++)
                                            {
                                                Console.WriteLine("Enter information of student at position {0}", (i + 1));
                                                Student sv = new Student();
                                                sv.Add();
                                                student.Add(sv);
                                                Console.WriteLine("Add successfully");
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            for (int i = 0; i < student.Count; i++)
                                            {
                                                Console.WriteLine("The information of student at position {0}", (i + 1));
                                                student[i].View();
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            
                                            Console.WriteLine("Enter the name of student need to find:");
                                            string xname = Console.ReadLine();
                                            bool ab = true;
                                            for (int i = 0; i < student.Count; i++)
                                            {
                                                if (student[i].Stname == xname)
                                                {
                                                    student[i].View();
                                                    ab = false;
                                                }                                                
                                            }
                                            if (ab == true)
                                            {
                                                Console.WriteLine("The student with that id doesn’t exist.");
                                            }
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.WriteLine("Enter first ID need to delete:");
                                            string xfID = Console.ReadLine();
                                            Console.WriteLine("Enter last ID need to delete:");
                                            int xlID = int.Parse(Console.ReadLine());
                                            bool ab = true;
                                            for (int i = 0; i < student.Count; i++)
                                            {
                                                if (student[i].FID == xfID && student[i].LID == xlID)
                                                {
                                                    student[i].View();
                                                    student.RemoveAt(i);
                                                    Console.WriteLine("Delete successfully");
                                                    ab = false;
                                                }
                                            }
                                            if(ab == true)
                                            {
                                                Console.WriteLine("The student with that id doesn’t exist.");
                                            }
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.WriteLine("Enter first ID need to update:");
                                            string xfID = Console.ReadLine();
                                            Console.WriteLine("Enter last ID need to update:");
                                            int xlID = int.Parse(Console.ReadLine());
                                            bool ab = true;
                                            for (int i = 0; i < student.Count; i++)
                                            {
                                                if (student[i].FID == xfID && student[i].LID == xlID)
                                                {
                                                    student[i].View();
                                                    Student update = student[i];
                                                    student.RemoveAt(i);
                                                    Student Up = new Student();
                                                    string a = update.FID;
                                                    int b = update.LID;
                                                    Up.Add();
                                                    student.Add(Up);
                                                    Console.WriteLine("Update successfully");
                                                    ab = false;
                                                }                                                
                                            }
                                            if(ab == true)
                                            {
                                                Console.WriteLine("The student with that id doesn’t exist.");
                                            }
                                            
                                            break;
                                        }
                                    case 6:
                                        {
                                            Flag = false;
                                            break;
                                        }
                                }
                            } while (Flag == true);
                            break;
                        }                       
                    case 2:
                        {
                            do
                            {
                                Flag = true;
                                Console.WriteLine("Choose function:");
                                Console.WriteLine("1. Add new lecture");
                                Console.WriteLine("2. View all lectures");
                                Console.WriteLine("3. Search lectures");
                                Console.WriteLine("4. Delete lectures");
                                Console.WriteLine("5. Update lecture");
                                Console.WriteLine("6. Back to main menu");
                                Console.Write("Your choice:");
                                n2 = int.Parse(Console.ReadLine());
                                switch (n2)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Enter number of teacher:");
                                            do
                                            {
                                                St = Convert.ToInt32(Console.ReadLine());
                                                if (St <= 0)
                                                {
                                                    Console.WriteLine("Error! Number must greater than 0!");
                                                    Console.Write("Enter again:");
                                                }
                                                else break;
                                            } while (St > 0);

                                            for (int i = 0; i < St; i++)
                                            {
                                                Console.WriteLine("Enter information of teacher at position {0}", (i + 1));
                                                Teacher te = new Teacher();
                                                te.Add();
                                                teacher.Add(te);
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            for (int i = 0; i < teacher.Count; i++)
                                            {
                                                Console.WriteLine("The information of teacher at position {0}", (i + 1));
                                                teacher[i].View();
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("Enter the name of teacher need to find:");
                                            string xname = Console.ReadLine();
                                            for (int i = 0; i < teacher.Count; i++)
                                            {
                                                if (teacher[i].Name == xname)
                                                {
                                                    teacher[i].View();
                                                }
                                            }
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.WriteLine("Enter ID need to delete:");
                                            int xID = int.Parse(Console.ReadLine());
                                            bool ab = true;
                                            for (int i = 0; i < student.Count; i++)
                                            {
                                                if (teacher[i].ID == xID && teacher[i].ID == xID)
                                                {
                                                    teacher[i].View();
                                                    teacher.RemoveAt(i);
                                                    Console.WriteLine("Delete successfully");
                                                    ab = false;
                                                }                                                
                                            }
                                            if (ab == true)
                                            {
                                                Console.WriteLine("The teacher with that id doesn’t exist.");
                                            }
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.WriteLine("Enter ID need to update:");
                                            int xID = int.Parse(Console.ReadLine());
                                            bool ab = true;
                                            for (int i = 0; i < teacher.Count; i++)
                                            {
                                                if (teacher[i].ID == xID && teacher[i].ID == xID)
                                                {
                                                    teacher[i].View();
                                                    Teacher update = teacher[i];
                                                    teacher.RemoveAt(i);
                                                    Teacher Up = new Teacher();
                                                    int b = update.ID;
                                                    Up.Add();
                                                    teacher.Add(Up);
                                                    ab = false;
                                                }                                                
                                            }
                                            if (ab == true)
                                            {
                                                Console.WriteLine("The teacher with that id doesn’t exist.");
                                            }
                                            break;
                                        }
                                    case 6:
                                        {
                                            Flag = false;
                                            break;
                                        }
                                }

                            } while (Flag == true);
                            break;
                        }
                    case 3:
                        {
                            Function f = new Function();
                            f.Exit(n);
                            break;
                        }
                }
            }while (Flag == false) ;            
        }
    }            
}

