using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoD_ArrayTest
{
    class TdArray4
    {
        static void Main(string[] args)
        {
            Verification_Code1(); //生成的验证码存在重复
            //Verification_Code2(); //生成的验证码不存在重复
        }

        static void Verification_Code1()
        {
            //1. 定义codes数组，并赋值(26个大写，26小写，10个数字）
            char[] codes = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K',
                'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
                'Y', 'Z', 'f', 'g', 'h', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                'i', 'j', 'k', 'l', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] code = new char[4]; //2.定义一个验证码数组，存放随机产生的4位验证码
            Random r = new Random(); //3. 新建一个 随机数变量r

            for (int i = 0; i < code.Length; i++)// 利用for循环依次取出4个元素并放到相应的数组中
            {
                //调用 Next()方法,获取一个codes.Length范围内的任意数字
                int index = r.Next(codes.Length);  //拿到 index 在codes数组中的位置上的那个字符
                                                   //比如：index为4，那么就取出codes[4]位置上的那个字符                                                   
                code[i] = codes[index]; //将字符赋值给验证码数组
            }

            Console.Write("产生的验证码为："); //4.遍历code数组
            foreach (char c in code)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }

        static void Verification_Code2()
        {
            //1. 定义codes数组，并赋值(26个大写，26小写，10个数字）
            char[] codes = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K',
                'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
                'Y', 'Z', 'f', 'g', 'h', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                'i', 'j', 'k', 'l', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] code = new char[4]; //2.定义一个验证码数组，存放随机产生的4位验证码

            Random r = new Random(); //3. 新建一个 随机数变量r

            bool[] isChecked = new bool[codes.Length];//标志数组的长度和codes数组长度保持一致

            int count = 0;

            //构建while循环,因为不能确定需要取多少次,所以条件为true
            while (true)
            {

                int index = r.Next(codes.Length);  //获取一个codes.Length范围内的任意数字

                if (isChecked[index])//使用if语句判断 index 位置上的那个字符有没有被选过
                                     //如果被选中过,则继续进行下一次循环,如果没有选过,if语句不执行,执行这里的代码
                {
                    continue;
                }
                code[count++] = codes[index]; //拿到 index 在codes数组中的位置上的那个字符放到验证码数组中
                                              //然后马上将isChecked数组中index位置上那个字符的标志设置为 false
                isChecked[index] = true;//保证下一次这个位置上的字符不会再被选          


                if (count == 4) //添加循环结束的条件
                                //count变量用于表示验证码下标 ,且一直在累加,所以当count的值等于4,循环可以结束
                {
                    break;//跳出循环
                }

                Console.Write("产生的验证码为："); //4.遍历code数组
                foreach (char c in code)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


