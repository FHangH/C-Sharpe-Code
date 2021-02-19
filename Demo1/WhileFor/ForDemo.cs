using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileFor
{
    class ForDemo
    {
        static void Main(string[] args)
        {
            int i, sum, count;
            for (i = 0, sum = 0, count = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                    sum += i;
                }
            }
            Console.WriteLine("100内的偶数个数：" + count);
            Console.WriteLine("100内的偶数总和：" + sum);
        }
    }
}
