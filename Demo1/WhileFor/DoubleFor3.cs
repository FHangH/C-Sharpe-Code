using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileFor
{
    class DoubleFor3 //循环嵌套
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j % 2 == 0)
                    {
                        break;
                    }
                    Console.Write("j=" + j);
                }
                Console.WriteLine();
                sum += i;
            }
            Console.WriteLine("sum=" + sum);
        }
    }
}
