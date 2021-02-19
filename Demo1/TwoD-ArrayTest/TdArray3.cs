using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoD_ArrayTest
{
    class TdArray3
    {
        static void Main(string[] args)
        {
            int[,] list1 = new int[3, 3]; //定义一个3行3列的动态二维数组
            Random r = new Random(); //定义一个随机数r
                                     //如果该句放在外层内，内层外，遍历出来的二维数组，每一行数组相同
                                     //放在内层中，二维数组中的所有元素相同

            for (int i = 0; i < list1.GetLength(0); i++) //i为行数
            {
                for (int j = 0; j < list1.GetLength(1); j++) //j为列数
                {
                    list1[i, j] = r.Next(0, 10); //随机数的取值范围是0到9之间，并赋值给二维数组中的每一个元素
                }
            }

            Console.WriteLine("Two-dimensional Array: ");
            for (int m = 0; m < list1.GetLength(0); m++) //遍历上面创建好的二维数组
            {
                for (int n = 0; n < list1.GetLength(1); n++)
                {
                    Console.Write(list1[m, n] + "\t"); //打印二维数组
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int sum = 0; //定义两条对角线所经过的数组元素值和为sum
            for (int m = 0; m < list1.GetLength(0); m++)
            {
                for (int n = 0; n < list1.GetLength(1); n++)
                {
                    if (m==n || m + n == 2) //3行3列的两条对角线所经过的数组下标符合该句的情况
                    {
                        sum += list1[m, n];
                    }
                }
            }
            Console.Write("两条对角线所经过的数组元素和为：" + sum);
            Console.WriteLine();
        }
    }
}
