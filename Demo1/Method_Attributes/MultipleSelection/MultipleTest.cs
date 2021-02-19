using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Attributes.MultipleSelection
{
    class MultipleTest
    {
        static void Main(string[] args)
        {
            Multiple q1 = new Multiple(); //新建一个对象q1

            q1.Number = 1; //题号
            q1.Text = "Which games are Crysis series( )"; //题目
            q1.Options = new string[] { "A. Crysis1", "B. Crysis2", "C. Crysis3", "D. FarCry" }; //选项
            q1.Answer = new string[] { "A", "B", "C" }; //答案
            q1.Print(); //打印整个题目

            //此处设置一个用户输入答案，判断与Answer是否相同
            Console.Write("Enter your choice(Separate by Space and Not case Sensitive): ");
            string input = Console.ReadLine();
            string[] a = input.Split(' '); //Split(' ')为对输入的字符，每遇到一个空格，就将之前输入的字符存到 a数组 
            bool result = q1.Check(a); //将 a数组 做为实参传递到Multiple.cs中的Check类中
            if (result) //将Check类中返回的bool值给result，判断后，打印结果
            {
                Console.WriteLine("Answer is true!");
            }
            else
            {
                Console.WriteLine("Answer is false!");
            } 
        }
    }
}
