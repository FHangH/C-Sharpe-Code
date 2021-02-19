using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    /// <summary>
    /// 数组的拷贝
    /// 数组的排序
    /// 数组的逆转
    /// 数组的清空
    /// </summary>
    class Array4
    {
        static void Main(string[] args)
        {
            int[] list = { 12, 32, 46, -10, 50, 72 }; //原数组
            Console.Write("原数组：");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("**********此处分割**********");
            Console.WriteLine();

            Array.Reverse(list); //逆转数组
            Console.Write("逆转数组：");
            foreach (int j in list)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            Console.WriteLine("**********此处分割**********");
            Console.WriteLine();

            Array.Sort(list); //数组排序
            Console.Write("数组排序：");
            foreach (int n in list)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.WriteLine("**********此处分割**********");
            Console.WriteLine();

            //Array.Copy(源数组名， 目标数组名， 拷贝的长度)
            int[] list2 = new int[list.Length];  //定义一个动态的目标数组
            Array.Copy(list, list2, list.Length); //数组拷贝
            Console.Write("数组拷贝：");
            foreach (int m in list2)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();
            Console.WriteLine("**********此处分割**********");
            Console.WriteLine();

            //Array.Clear（需要清空的数组名， 从某一个数组下标开始清空， 需要清空的数组长度）
            Console.Write("清空前的数组：");
            double[] list3 = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 }; //定义一个清空前的double类型数组List3
            foreach(double list4 in list3) //先将List3的数组元素遍历到List4中，打印显示，和后面清空后的数组做对比
            {
                Console.Write(list4 + " ");
            }
            Console.WriteLine();

            Array.Clear(list3, 1, 3); //清空数组List3，从数组下标为1的数组元素开始，往后清空3个元素
            Console.Write("清空后的数组：");
            foreach(double k in list3) //将清空后的数组遍历到k中，和上面清空前的数组List4做对比
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            Console.WriteLine("**********此处分割**********");
            Console.WriteLine();
        }
    }
}
