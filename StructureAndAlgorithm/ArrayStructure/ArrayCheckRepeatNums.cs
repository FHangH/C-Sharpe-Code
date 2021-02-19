using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayStructure
{
    class ArrayCheckRepeatNums
    {
        static void Main(string[] args)
        {
            int intCreateFre = 1000000;
            Random randNum = new Random();
            int[][] intArray = new int[2][];
            intArray[0] = new int[42];
            intArray[1] = new int[42];
            int intRandNum;

            while (intCreateFre-- > 0)
            {
                intRandNum = randNum.Next(42);
                intArray[0][intRandNum]++;
                intArray[1][intRandNum]++;
            }

            Array.Sort(intArray[0]);

            for (int i = 41; i > (41 - 6); i--)
            {
                for (int j = 41; j >= 0; j--)
                {
                    if (intArray[0][i] == intArray[1][j])
                    {
                        WriteLine($"随机数{j + 1}出现{intArray[0][i]}次");
                        intArray[1][j] = 0;
                        break;
                    }

                }
            }
        }
    }
}
