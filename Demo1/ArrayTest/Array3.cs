using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Array3 //动态数组的定义，输入数组，数组求和，求平均数。
    {
        static void Main(string[] args) //通过键盘输入数值做为动态数组的元素
        {
            int sum = 0; //定义一个数组和的变量名
            int[] nums = new int[5]; //定义一个长度为5的动态数组
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("please enter " + i + " num: "); //通过键盘输入数字
                string str = Console.ReadLine(); //将输入的数字转成字符
                nums[i] = int.Parse(str); //将字符再转为数字给nums
                Console.WriteLine(nums[i]); //每输入一个数字，就打印数组元素

                sum += nums[i]; //求每次输入的数组的和
            }
            float ave = (float)sum / nums.Length; //(float)sum将sum强制转换成浮点类型

            Console.WriteLine("Enter array sum is : " + sum); //输出数组的和
            Console.WriteLine("Enter array ave is : " + ave); //输出数组的平均值
        }
    }
}
