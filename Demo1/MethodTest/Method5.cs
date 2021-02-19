using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MethodTest
{
    class Method5 //键盘输入一个正整数，求阶乘
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a int number : ");

            string str = Console.ReadLine();
            int num = int.Parse(str);

            BigInteger result = Factorial(num); //定义一个long类型的result变量，接收Factorial（）方法返回的值
                                                //num为实参 
                                                //BigInteger是C#中任意大的带符号的整数(long会有限制)
            Console.WriteLine(num + "! is " + result);
        }

        static BigInteger Factorial(int number) //定义一个long类型得到方法形参
        {
            BigInteger sum = 1;
            for (int i = number; i >= 1; i--) //求阶乘
            {
                sum = sum * i;
            }
            return sum; //将求得的阶乘值，返回到Main中，进行调用
        }
    }
}
