using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Array5 //冒泡排序法
    {
        static void Main(string[] args)
        {
            int[] list = { 10, -1, -2, -10 }; //先定义一个int类型的数组，其中有4个数组元素
            Console.Write("原数组：");
            foreach (int k in list) //通过foreach进行遍历，将原数组list中的数组元素遍历到k中，依次打印
            {
                Console.Write(k + " "); //将原数组list打印出来，以便和后面排序后的数组list2进行比较
            }
            Console.WriteLine();
            for (int i = 1; i < list.Length; i++) //list中有4个元素，需要比较3轮，i=1，表示从第一轮开始
            {
                for (int j = 0; j < list.Length - 1; j++) //每一轮中，每一个元素都要按顺序两两比较，第一轮比较三次
                                                          //j为数组下标，所以j初始值为0
                {
                    if (list[j] > list[j + 1]) //判断两两比较的元素大小，小的排前面，大的排后面
                    {
                        int temp = list[j]; //将大的值赋值给中间变量temp
                        list[j] = list[j + 1]; //将小的值赋值给前面大的元素
                        list[j + 1] = temp; //再将拥有大的值的中间变量给原来小的值的元素
                    }
                }
            }
            Console.Write("从小到大排序后：");
            foreach(int list2 in list) //再将重新排序后的数组打印出来
            {
                Console.Write(list2 + " ");
            }
            Console.WriteLine();
        }
    }
}
