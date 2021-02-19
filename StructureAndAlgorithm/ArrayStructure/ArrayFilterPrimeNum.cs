using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayStructure
{
    class ArrayFilterPrimeNum
    {
        static void Main(string[] args)
        {
            const int Max = 300;

            //true is not prime num, default value is false
            bool[] prime = new bool[Max];
            prime[0] = true;
            prime[1] = true;

            int num = 2, i; //2 >> i

            while (num < Max)
            {
                if (!prime[num])
                {
                    for (i = num + num; i < Max; i += num)
                    {
                        if (prime[i])
                        {
                            continue;
                        }
                        prime[i] = true;
                    }
                }
                num++;

            }

            WriteLine($"1 to {Max} all prime num: ");

            for (i = 2, num = 0; i < Max; i++)
            {
                if (!prime[i])
                {
                    Write(i + "\t");
                    num++;
                }
            }

            WriteLine("\nprime nums sum = " + num);
        }
    }
}
