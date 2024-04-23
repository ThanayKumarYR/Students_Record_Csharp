using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class EditDetails
    {
        public static void EditingStudents(ArrayList list)
        {
            Console.WriteLine("Editing Student details");
            Console.Write("Enter the id: ");
            string id = Console.ReadLine();

            if (id.Length == 0)
            {
                Console.WriteLine("Id cannot be null");
                return;
            }
            else if (id.Length > 0)
            {
                foreach (Student item in list)
                {
                    if (item.Id == id)
                    {
                        while (true)
                        {
                            Console.WriteLine("\nEnter 1 -> edit id");
                            Console.WriteLine("Enter 2 -> edit name");
                            Console.WriteLine("Enter 3 -> edit address");
                            Console.WriteLine("Enter 4 -> edit phone number");
                            Console.WriteLine("Enter 5 -> to quit the editing");


                            Console.Write("Enter the choice = ");
                            int choice = int.Parse(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    Console.Write("\nEdit the id = ");
                                    item.Id = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Write("\nEdit the name = ");
                                    item.Name = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("\nEdit the Address = ");
                                    item.Address = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.Write("\nEdit the Phone Number = ");
                                    item.PhoneNumber = Console.ReadLine();
                                    break;
                                case 5:
                                    return;
                                default:
                                    Console.WriteLine("Invalid input !");
                                    break;
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Entered id is not in the Students data !");
                    }
                }
            }

        }
    }
}
