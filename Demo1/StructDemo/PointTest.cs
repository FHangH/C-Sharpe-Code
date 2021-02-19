using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    class PointTest
    {
        static Point p3; //3.声明一个静态的Point方法 p3 全局变量
        static void Main(string[] args)
        {
            Point p1 = new Point(); //1.创建一个Point结构对象
            p1.X = 10;
            Console.WriteLine(p1.X);
            p1.Print();

            Console.WriteLine("------------------");

            Point p2 = new Point(20); //2.
            Console.WriteLine(p2.X);

            Console.WriteLine("------------------");
            p3.X = 30;
            Console.WriteLine(p3.X);
        }
    }
}
