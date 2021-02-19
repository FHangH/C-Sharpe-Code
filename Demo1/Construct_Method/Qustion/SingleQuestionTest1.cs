using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_Method.Qustion
{
    class SingleQuestionTest1
    {
        static void Main(string[] args)
        {
            SingleQuestion q = new SingleQuestion();

            //传给SingleQuestion的实参（数组），需要提前定义一个数组
            string[] options = { "A. Crysis1", "B. Crysis2", "C. Crysis3", "D. Farcry" };
            SingleQuestion q1 = new SingleQuestion(
                1,
                "以下哪一个不是孤岛危机系列( ).",
                options,
                "D"); //将实参传递给SingleQuestion.cs中的id1方法中 
            Console.WriteLine("题号：" + q1.num);
            Console.WriteLine("题目：" + q1.text);
            
            foreach (string opt in q1.options) //需要将options内的string类型数组的元素进行遍历，才能传递给SingleQuestion
            {
                Console.WriteLine("\t" + opt);
            }

            Console.WriteLine("答案：" + q1.answer);
        }
    }
}
