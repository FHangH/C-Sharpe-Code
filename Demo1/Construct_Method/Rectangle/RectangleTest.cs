using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_Method.Rectangle
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(20.0d, 15.0d);
            Console.WriteLine("Calculation rectangle area and perimeter: ");
            Console.WriteLine("rectangle message: " + "height: " + r1.GetHeight() + "cm" + " width: " + r1.GetWidth() + "cm");            
            Console.WriteLine("\t" + "area: " + r1.Area() + "cm^2");
            Console.WriteLine("\t" + "perimeter: " + r1.Perimeter() + "cm");
        }
    }
}
