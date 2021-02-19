using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoD_ArrayTest
{
    class TdArray2 //二维数组遍历
    {
        static void Main(string[] args)
        {
            int[,] list1 = { { 10, 20 }, { 30, 40 }, { 50, 60 } }; //先定义一个静态二维数组
            Console.WriteLine("Two-dimensional Array: ");
            Console.WriteLine("二维数组的行数：" + list1.GetLength(0)); //GetLength(0)表示返回Array中一维的元素个数；
                                                                        //list1是个3行一维数组组成

            Console.WriteLine("二维数组的列数：" + list1.GetLength(1)); //GetLength(1)表示二维，返回一维中的元素个数；
                                                                        //list1是个2列一维数组组成      

            Console.WriteLine("二维数组的个数：" + list1.Length);

            for (int i = 0; i < 3; i++) //外层控制行数，数组遍历从下标0开始，所以i=0， j=0
            {
                for (int j = 0; j < 2; j++) //内层控制列数
                {
                    Console.Write(list1[i, j] + "\t"); //将遍历出来的i，j一起打印出来
                }
                Console.WriteLine();
            }
        }
    }
}
