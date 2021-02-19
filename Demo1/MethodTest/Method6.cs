using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    class Method6 //将新的数插入一个数组指定的位置，构成一个新的数组
    {
        static void Main(string[] args)
        {
            int[] Array1 = { -1, 2, 8, -2, 10 };
            int[] Array2 = new int[Array1.Length + 1]; //新数组比原数组多一位

            Console.WriteLine();
            Console.WriteLine("************原数组************");
            Console.Write("原数组：");
            foreach (int x in Array1) //先遍历原数组并打印
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*********输入相关数据*********");
            Console.Write("希望插入数组的数：");
            string str1 = Console.ReadLine();
            int num = int.Parse(str1); //将要插入的新数赋值给num

            Console.Write("希望将新的数插入的位置：");
            string str2 = Console.ReadLine();
            int str3 = int.Parse(str2); //选择插入的位置从小标为1开始算，赋值给str3（str2转化成int类的数）
            int position = str3 - 1; //数组默认的小标从0开始，而选择的位置为1，所以要减1，并赋值给position

            Insert(Array1, Array2, position, num); //分别调用Insert方法

            Console.WriteLine();
            Console.WriteLine("**********生成新数组**********");
            Console.Write("新数组：");
            foreach (int y in Array2) //调用方法后，将方法返回的Array2进行遍历，并打印
            {
                Console.Write(y + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static int[] Insert(int[] Array1, int[] Array2, int position, int num) //定义一个数组类型的Insert方法
        {
            Array.Copy(Array1, Array2, Array1.Length); //将Array1中的数组全部拷贝到Array2中

            for (int i = Array2.Length-1; i > position; i--) //插入新数组时，插入位置之后的数组从最后一位开始，向最后一个位置移动
                                                             //当插入位置之后所有的数组排好后，停止排序
                                                             //Array2最后一位是空的，用于存放最后一个数，原位置被前面的数代替
                                                             //依次类推，直到空出一个选定的插入位置position
            {
                Array2[i] = Array2[i - 1]; //将前面的数赋值给后面数
            }
            Array2[position] = num; //将要插入的新数赋值给空出来的位置position
            return Array2; //返回插入新数后的新数组值
        }
    }
}
