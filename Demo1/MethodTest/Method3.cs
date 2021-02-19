using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    class Method3 //找出数组里的最大数
    {
        static void Main(string[] args)
        {
            MaxNumber();
        }

        static int MaxNumber()
        {
            int[] list1 = { 10, -1, 70, 1000 };
            int max = list1[0]; //先假设第一个数最大

            for (int i = 0; i < list1.Length; i++) //将数组内的数进行遍历
            {
                if (max < list1[i]) //每遍历一个数，便和max比较
                {
                    max = list1[i]; //最大的数，赋值给变量max
                }
            }
            Console.WriteLine("MaxNumber is : " + max);
            return max;
        }
    }
}
