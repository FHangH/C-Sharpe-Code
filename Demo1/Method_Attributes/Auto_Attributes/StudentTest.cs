using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Attributes.Auto_Attributes
{
    class StudentTest
    {static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "FH";
            s1.Number = 123;
            Console.WriteLine("Name: " + s1.Name + "\n" + "Number: " + s1.Number);
        }
    }
}
