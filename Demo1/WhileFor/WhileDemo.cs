using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileFor
{
    class WhileDemo
    {
        static void Main(string[] args)
        {
            Console.Write("请输入要计算的值（正整数）：");
            string ex = Console.ReadLine();
            int exm = int.Parse(ex);
            int count = 0;
            int sum = 0;
            do
            {
                if (exm % 2 == 0)
                {
                    count = count + 1;
                    sum = sum + exm;
                }

                exm--;
            } while (exm >= 1);
            Console.WriteLine(ex + "内的偶数个数： " + count);
            Console.WriteLine(ex + "内的偶数总和： " + sum);
        }
    }
}
