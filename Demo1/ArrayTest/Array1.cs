using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Array1
    {
        static void Main(string[] args)
        {
            //静态数组
            //组成：数组类型[] 数组名 = {元素}
            int[] nums = { 11, 12, 13, 14 };
            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);
            Console.WriteLine(nums[2]);
            Console.WriteLine(nums[3]);

            //动态数组
            //组成：数组类型[] 数组名 = new 数组类型[元素数量]
            //动态数组int类型默认0，floa|double默认0.0，bool默认false
            int[] exmp = new int[20];
            Console.WriteLine(exmp);

            int[] test1;
            test1 = new int[20];
            Console.WriteLine(test1);

            //动态数组和静态数组的结合使用
            int[] test2 = new int[5] { 12, 13, 14, 15, 16 };
            Console.WriteLine(test2);
        }
    }
}
