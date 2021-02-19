using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    /// <summary>
    /// 如果方法返回值定义的是void，怎不用写return，系统默认return；
    /// 如果方法返回值定义的是int类型，则return后面要接对应的类型；可以是一个普通的值，也可以是能计算出对应表达式；
    /// 例子：Print_Hello（）；
    /// </summary>
    class Method2 //四则运算 
    {
        static void Main(string[] args)
        {
            //Arithmetic_add(1000, 100); //两个整数之和
            //Arithmetic_reduce(1000, 100); //两个数相减
            //Arithmetic_multiply(1000, 100); //两个数相乘
            //Arithmetic_division(1000, 100); //两个数相除
            Console.WriteLine(Print_Hello()); //例子：方法返回值定义的为string类型，return后面接上string类型的字符串和表达式；

        }

        static int Arithmetic_add(int a, int b) //定义一个int类，形参为int，返回值也为int
        {            
            int sum = a + b;
            Console.WriteLine(a + " + " + b +": " + sum);

            return sum; //返回一个int的值
        }

        static int Arithmetic_reduce(int a, int b)
        {
            int reduce = a - b;
            Console.WriteLine(a + " - " + b + ": " + reduce);

            return reduce;
        }

        static int Arithmetic_multiply(int a, int b)
        {
            int multiply = a * b;
            Console.WriteLine(a + " * " + b + ": " + multiply);

            return multiply;
        }

        static int Arithmetic_division(int a, int b)
        {
            int division = a / b;
            Console.WriteLine(a + " / " + b + ": " + division);

            return division;
        }

        static string Print_Hello()
        {
            return "Hello" + " World! ";
        }
    }
}
