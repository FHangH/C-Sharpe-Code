using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Attributes.MultipleSelection
{
    class Multiple //多选
    {
        //使用自动属性完成多选题的需求,多选题的答案不止一个，所以设为数组
        public int Number { set; get; } //题号
        public string Text { set; get; } //题目
        public string[] Options { set; get; } //选项
        public string[] Answer { set; get; } //答案

        public void Print() //在控制台中打印内容
        {
            Console.WriteLine("Question: ");
            Console.Write("\t" + Number + ".");
            Console.Write(Text + "\n");

            foreach (string opt in Options) 
            {
                Console.WriteLine("\t" + opt);
            }

        }

        public bool Check(string[] inputAnswer) //定义一个选项类，形参类型为数组，形参inputAnswer的传入数组为a
        {
            if (inputAnswer.Length != Answer.Length) //判断传入数组的长度是否等于Answer的长度，如果长度不同，返回false
            {
                return false;
            }

            Array.Sort(Answer); //对Answer，inputAnswer进行排序，目的为使得输入数组的顺序不需要和Answer一致
            Array.Sort(inputAnswer);

            for (int i = 0; i < inputAnswer.Length; i++) //对传入的数组元素进行逐个与Answer内数组元素进行比较
            {
                if (!Answer[i].Equals(inputAnswer[i], StringComparison.CurrentCultureIgnoreCase)) //如果有一个不同，返回false
                {
                    return false;
                }
            }
            return true; //如果长度和元素都相同，返回true给MultipleTest.cs的bool值result，进行判断
        }
    }
}
