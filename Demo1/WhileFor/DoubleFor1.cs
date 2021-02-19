using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileFor
{
    class DoubleFor1
    {
        static void Main(string[] args)
        {
            //一开始的写法
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //    for (int j = 1; j <=9; j++)
            //    {
            //        Console.Write("*");
            //        if (j == 9)
            //        {
            //            Console.Write("\n");
            //        }
            //    }
            //}
            //精简的写法
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }            
    }
}
