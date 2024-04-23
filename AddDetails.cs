using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class AddDetails
    {
        public static Student AddingDetails()
        {
            Console.Write("\nEnter the id = ");
            string id = Console.ReadLine();
            Console.Write("Enter the name = ");
            string name = Console.ReadLine();
            Console.Write("Enter the address = ");
            string address = Console.ReadLine();
            Console.Write("Enter the phone number = ");
            string phonenumber = Console.ReadLine();

            Student student = new Student(id,name,address,phonenumber);

            return student;
        }
    }
}
