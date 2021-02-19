using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructureAndAlgorithm
{
    class FibonacciTest2
    {
        static void Main(string[] args)
        {
            int num;
            string str;

            WriteLine("使用动态规划法计算斐波拉契数列的执行次数");
            Write("请输入一个整数：");

            str = ReadLine();
            num = int.Parse(str);
            if (num < 0)
            {
                WriteLine("输入的数字必须大于等于0\n");
            }
            else
            {
                Write("Fibonacci(" + num + ")=" + Fib(num) + "\n");
                Write("Fibonacci(" + num + ")的执行次数为 " + Fib(num) + "\n");
            }
        }

        static int[] output = new int[1000];

        static int Fib(int n)
        {
            int result;
            result = output[n];

            if (result == 0)
            {
                if (n == 0)
                {
                    return 0;
                }
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return (Fib(n - 1) + Fib(n - 2));         
                }
            }
            output[0] = result;
            return result;
        }
    }
}
