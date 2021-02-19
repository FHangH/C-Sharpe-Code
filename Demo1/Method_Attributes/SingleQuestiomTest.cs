using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Attributes
{
    class SingleQuestiomTest
    {
        /// <summary>
        /// 属性的调用方法：
        ///     类名(属性所在的类名) 对象名 = new 类名();
        ///     对象名.属性名 = 实参值(属性内set对应的字段类型值);
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SingleQuestion q1 = new SingleQuestion();
            q1.Number = 1;
            Console.WriteLine("question " + q1.Number + ": ");

            q1.Text = "Pick out a game that is not Crysis serise( ).";
            Console.WriteLine("\t" + q1.Text);

            string[] options = { "A.Crysis1", "B.Crysis2", "C.Crysis3", "D.FarCry" };
            q1.Options = options; //定义的数组要赋值给q1.Options；
                                  //实则赋值给SingleQuestion.cs类中Options属性默认的value值
            foreach (string opt in q1.Options)
            {
                Console.WriteLine("\t" + opt);
            }
            q1.Answer = "D"; //传入Answer实参，需要写在ReadLine()前面，否则Check属性中比较的answer值为空值

            Console.WriteLine("Please check a option in A B C D");
            Console.Write("Enter: ");
            string inputAnswer = Console.ReadLine();
            bool result = q1.Check(inputAnswer); //将返回的bool值，赋值给result，用于打印           
            Console.WriteLine("The answer " + inputAnswer + " is " + result);

            
            Console.WriteLine("\t" + "The answer is : " + q1.Answer);
        }
    }
}
