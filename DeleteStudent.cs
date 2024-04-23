using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class DeleteStudent
    {
        public static void DeletingStudents(ArrayList list)
        {
            try
            {

                Console.WriteLine("Deleting Student record");
                Console.Write("Enter the name: ");
                string name = Console.ReadLine();

                if (name.Length == 0 )
                {
                    Console.WriteLine("Name cannot be null");
                    return;
                }
                else if (name.Length > 0)
                {
                    foreach (Student item in list)
                    {
                        if (item.Name == name)
                        {
                            Console.WriteLine("Confirm delation !");
                            Console.Write("Press Y || y for YES = ");
                            char decision = char.Parse(Console.ReadLine());
                            if (decision == 'Y' || decision == 'y')
                            {
                                list.Remove(item);
                                Console.WriteLine("Successfully deleted !");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entered name is not in the Student data !");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

            }
        }
    }
}
