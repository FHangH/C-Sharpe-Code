using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Array2 //for循环遍历动态数组
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3] { 12, 11, 112 };
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            //遍历数组(倒序)
            /*for (int i = nums.Length - 1; i >= 0; i--)
            {   //打印每个元素的值
                Console.WriteLine(nums[i]);
            }*/
        }
    }
}
