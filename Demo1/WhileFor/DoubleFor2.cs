﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileFor
{
    class DoubleFor2 //乘法表
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + "*" + j + "=" + (i * j) + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
