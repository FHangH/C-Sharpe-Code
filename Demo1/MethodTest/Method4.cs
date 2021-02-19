using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    class Method4 //从键盘输入一个整数，判断是否为8的倍数
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            string str = Console.ReadLine(); //从键盘输入整数字符
            int num = int.Parse(str); //将字符转化为int
            bool result = EightNumber(num); //将EightNumber方法得到的bool值赋值给result

            string str1 = " is EightNumber ";
            string str2 = " is not EightNumber ";

            if (result == true) //判断result符合的条件，选择输出的语句
            {
                Console.WriteLine(result + str1);
            }
            else
            {
                Console.WriteLine(result + str2);
            }

        }

        static bool EightNumber(int number) //定义一个bool类
        {
            if (number % 8 == 0)
            {
                return true; //返回bool值
            }
            else
            {
                return false;
            }
        }
    }
}
