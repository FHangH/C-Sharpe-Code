using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    class Method1
    {
        static void Main(string[] args)
        {
            //Daffodil_Number1(); //求100-1000内的水仙花数和个数
            Daffodil_Number2(370); //求指定的数是否为水仙花数
                                   //此处为实参
        }

        /// <summary>
        /// 求水仙花数：
        /// 1.先将数字中的每一位取出
        /// 2.将取出的数字的三次方相加判断得出的数是否等于原数字
        /// 3.是：为水仙花；否：不是水仙花
        /// 4.水仙花数是三位数，1000以内的水仙花数从100-999之间得到
        /// </summary>
        static void Daffodil_Number1()
        {
            int count = 0; //存储水仙花个数

            Console.Write("Daffodil Number are : ");
            for (int number = 100; number < 1000; number++)
            {
                int a = number / 100; //取出百位的数
                int b = number / 10 % 10; //取出十位的数
                int c = number % 10; //取出个位的数
                double sum = Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3); //将每一个数的三次方相加，用于和原数判断是否相等
                                                                               //Math.Pow(a,3)表示a的三次方

                if (sum == number) 
                {
                    count++; //每得到一个水仙花数，就存储一次
                    Console.Write(number + " "); //输出的到的水仙花数
                }
            }
            Console.WriteLine();
            Console.WriteLine("Daffodil Number have " + count); //输出1000内的水仙花个数
        }

        static void Daffodil_Number2(int number) //次处为形参
        {
            int a = number / 100; 
            int b = number / 10 % 10; 
            int c = number % 10; 
            double sum = Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3);

            if (sum == number)
            {
                Console.WriteLine(number + " is Daffodil Number ");
            }
            else
            {
                Console.WriteLine(number + " is not Daffodil Number ");
            }
        }
    }
}
