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
    /// 使用顺序排序法进行从小到大排序
    /// 将排序后的数组进行遍历打印
    /// 
    /// 顺序排序法：
    /// 首先是数组中第一个数和第二个数进行比较；
    /// 如果第一个数大于第二个数，两个数互换位置；
    /// 接着，被移动到第一位的数继续和第三位进行比较，如果大于第三个数，和第三个数互换位置；以此类推到最后一位；
    /// 得到第一位最小的数；
    /// 第二轮开始时，从第二个数开始，和第三个数进行比较。。。
    /// 
    /// 列入 一个数组4个数，只需要进行m=3轮，每轮的开始元素向后面的元素比较，比较完，就进行下一轮
    /// </summary>
    class Array7 //顺序排序法
    {
        static void Main(string[] args)
        {
            int[] list1 = new int[8]; //定义一个长度为8的动态数组
            Random r = new Random(); //定义一个随机变量名r

            for (int i = 0; i < list1.Length; i++)
            {
                list1[i] = r.Next(0, 100); //随机变量r，在0-100中随机取值，100取不到，存入list1数组中
            }

            Console.Write("随机数组：");
            foreach (int k in list1) //将得到的随机变量数组遍历打印
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();

            for (int m = 0; m < list1.Length-1; m++) //通过顺序排序，将list1中的随机数组进行从小到大的排序
                                                     //m控制循环的轮数，m < list1.Length-1（四个数，只需要进行三轮）
            {
                for (int n = m + 1; n <list1.Length; n++) //n控制每一轮循环的次数
                {
                    if (list1[m] > list1[n]) //n = m + 1，第m元素与n比较
                    {
                        int temp = list1[m];
                        list1[m] = list1[n];
                        list1[n] = temp;
                    }
                }
            }
            Console.Write("从小到大排序后：");
            foreach (int list2 in list1) //将排序后的数组遍历如list2中进行打印，与原数组list1进行比较
            {
                Console.Write(list2 + " ");
            }
            Console.WriteLine();
        }
    }
}
