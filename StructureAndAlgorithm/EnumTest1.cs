using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructureAndAlgorithm
{
    class EnumTest1
    {
        static void Main(string[] args)
        {
            Enum1();
            WriteLine("#############");
            Enum2();
        }

        static void Enum1()
        {
            int x = 1;
            int num = 1000;
            while (num >= 0)
            {
                num -= x;
                x += 1;
            }

            Console.WriteLine(x - 1);
        }

        static void Enum2()
        {
            for (int num1 = 1; num1 < 501; num1++)
            {
                if (num1 % 5 == 0)
                {
                    Console.WriteLine(num1 + " 是5的倍数！");
                }
            }
        }
    }
}