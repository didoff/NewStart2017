using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmpData
    {
        static void Main(string[] args)
        {
            string fName = Console.ReadLine();
            string lName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalNum = long.Parse(Console.ReadLine());
            int uniqueEmpNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {fName}");
            Console.WriteLine($"Last name: {lName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalNum}");
            Console.WriteLine($"Unique Employee number: {uniqueEmpNum}");
        }
    }
}
