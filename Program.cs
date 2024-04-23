using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool displayed = false;
            Console.WriteLine("Welcome to Students record !\n");
            ArrayList list = new ArrayList();
            while (true)
            {
                Console.WriteLine("\nEnter 1 -> adding students details.");
                Console.WriteLine("Enter 2 -> edit student details via id.");
                Console.WriteLine("Enter 3 -> delete student's record.");
                Console.WriteLine("Enter 4 -> display all students record.");
                Console.WriteLine("Enter 5 -> display student record by id.");
                Console.WriteLine("Enter 6 -> exit the student's program !.\n");

                Console.Write("Enter the choice = ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Adding Students details !");
                        Student student = AddDetails.AddingDetails();
                        list.Add(student);
                        student.Display();
                        break;
                    case 2:
                        if (list.Count > 0)
                            EditDetails.EditingStudents(list);
                        else Console.WriteLine("Students record is empty !, please add details and then edit!");
                        break;
                    case 3:
                        if (list.Count > 0)
                            DeleteStudent.DeletingStudents(list);
                        else Console.WriteLine("Students record is empty !, please add details and then delete!");
                        break;

                    case 4:
                        if (list.Count > 0)
                            foreach (Student student1 in list) student1.Display();
                        else Console.WriteLine("Students record is empty !, please add details and then display");
                        break;
                    case 5:
                        if (list.Count > 0)
                        {
                            Console.WriteLine("Display a students detail !");
                            Console.Write("Enter the id: ");
                            string id = Console.ReadLine();
                            foreach (Student student1 in list)
                            {
                                if (student1.Id == id)
                                { 
                                    student1.Display();
                                    displayed = true;
                                    break ;
                                }
                            }
                            if (displayed == false) Console.WriteLine("Entered wrong id !");
                            else displayed = false;
                        }                            
                        else Console.WriteLine("Students record is empty !, please add details and then display");
                        break;
                    case 6:return;
                    default:
                        Console.WriteLine("Invalid input, enter value between 1 to 4");
                        break;
                    }
                }

            }
        }
}
