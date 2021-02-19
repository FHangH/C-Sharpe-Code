using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_Method.Qustion
{
    class SingleQuestion
    {
        //字段
        public int num; //题号
        public string text; //题目
        public string[] options; //选项
        public string answer; //答案

        public SingleQuestion() //无参数构造方法
        {
            Console.WriteLine("Test: 无参数构造方法");
        }

        public SingleQuestion(int QueNum, string QueText, string[] QueOptions, string QueAnswer) //id1方法
        {
            num = QueNum; //将QueNum收到的实参值，赋值给字段中的num，并返回到SingleQuestionTest1.cs中的q1
            text = QueText;
            options = QueOptions;
            answer = QueAnswer;
        }
    }
}
