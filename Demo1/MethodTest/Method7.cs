using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    /// <summary>
    /// 在二维数组中，找到最小数和最大数，并分别打印出来
    /// 只用一个方法：
    ///     在主方法中，先定义一个需要查找最小数和最大数的二维数组
    ///     在调用Value方法时，给定的参数中，除了数组参数，后面分别加上两个用于引出Value方法中得出的两个数
    ///     引出值的参数：out 类型 参数名
    /// </summary>
    class Method7
    {
        static void Main(string[] args)
        {
            int[,] Array = { { 10, 50, 89 }, { 15, 54, 68 }, { 85, 87, 61 }, { 15, 54, 98 } };
            Value(Array, out int min, out int max); //out int min 引出Value中的m
                                                    //out int max 引出Value中的n
                                                    //（这里的min和max就像人）
            Console.WriteLine("Array minValue is " + min);
            Console.WriteLine("Array maxValue is " + max);
        }

        static void Value(int[,] number, out int m, out int n) //方法中的参数分别对应着，二维数组，min，max
                                                               //out int m 引出被min赋值的m值
                                                               //out int n 引出被max赋值的n值
                                                               //（这里的min和max就像钥匙孔，只能被手里拿着对应钥匙的min和max打开）
        {
            int min = number[0, 0]; //假设第一个数为最小值
            int max = number[0, 0]; //假设第一个数为最大值

            for (int i = 0; i < 4; i++) //控制二维数的行数
            { 
                for (int j = 0; j < 3; j++) //控制二维数组的列数
                {
                    if (min > number[i, j]) //找到最小数
                    {
                        min = number[i, j]; //将最小数赋值给min
                    }
                    if (max < number[i, j]) //找到最大数
                    { 
                        max = number[i, j]; //将最大数赋值给max
                    }
                }
            }
            m = min; //将min的值赋值给m，用于从方法中引出并赋值给Main中的min
                     //（这里的m就是有对应钥匙的人能从这个房间里取走的东西）
            n = max; //将max的值赋值给n，用于从方法中引出并赋值给Main中的max
                     //（这里的n就是有对应钥匙的人能从这个房间里取走的东西）
        }
    }
}
