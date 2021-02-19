using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    /// <summary>
    /// 定义一个长度为8的动态数组
    /// 动态数组内的元素为[0， 100)的随机数
    /// 将动态数组遍历打印，于下面排序后的数组进行比较
    /// 使用冒泡排序法进行从小到大排序
    /// 将排序后的数组进行遍历打印
    /// 
    /// 冒泡法：
    /// 假设有个数组有4个数；
    /// 首先，第一轮，第一个数和第二个数两两进行比较，大的数排在第二位；
    /// 接着，第二轮时，被排到第二位的数和第三个数进行比较，大的数放在第三位，从小到大排列，以此类推；
    /// 4个数，m轮数为3，n次数为4-n；
    /// </summary>
    class Array6 
    {
        static void Main(string[] args)
        {
            int[] list1 = new int[8]; //定义一个长度为8的动态数组
            Random r = new Random(); //定义一个随机变量名r

            for(int i = 0; i < list1.Length; i++) 
            {
                list1[i] = r.Next(0, 100); //随机变量r，在0-100中随机取值，100取不到，存入list1数组中
            }

            Console.Write("随机数组：");
            foreach(int k in list1) //将得到的随机变量数组遍历打印
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();

            for (int m = 1; m < list1.Length; m++) //通过冒泡排序法对list1中的随机元素进行从小到大排序
                                                   //具体解释在ArrayTest.Array5.cs中
            {
                for(int n = 0; n <list1.Length-1; n++)
                {
                    if(list1[n] > list1[n + 1])
                    {
                        int temp = list1[n];
                        list1[n] = list1[n + 1];
                        list1[n + 1] = temp;
                    }
                }
            }
            Console.Write("从小到大排序后：");
            foreach(int list2 in list1) //将排序后的数组遍历如list2中进行打印，与原数组list1进行比较
            {
                Console.Write(list2 + " ");
            }
            Console.WriteLine();
        }
    }
}
