using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoD_ArrayTest //二维数组
{
    /// <summary>
    /// 二维数组：
    /// 静态二位数组:数组类型[,] 数组名 = {{行0，列0}，{行1，列1}.....}；
    /// 动态二维数组:数组类型[,] 数组名 = new 数组类型[行，列]；
    /// 
    /// 二维数组的行与列的下标从0开始
    /// </summary>
    class TdArray1
    {
        static void Main(string[] args)
        {
            //静态二维数组
            int[,] list1 = { { 10, 11 }, { 12, 13 }, { 14, 15 } };
            Console.WriteLine(list1[1, 0]);

            //动态二维数组
            int[,] list2 = new int[3, 2];
        }
    }
}
