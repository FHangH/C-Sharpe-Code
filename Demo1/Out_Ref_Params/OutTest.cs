using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Ref_Params
{
    class OutTest //out关键字
    {
        static void Main(string[] args)
        {
            int num; //num不在Main方法中赋值、
            float num1;
            ShowOut(out num, out num1); //本方法中，实参num的值不用赋值，赋值操作在其他方法中完成
            Console.WriteLine("num = " + num);
            Console.WriteLine("num1 = " + num1);
        }

        public static void ShowOut(out int num, out float num1) //此处方法的接收参数类型前面需要添加out
        {
            num = new Random().Next(100); //num的赋值操作，在此处完成, num的值为100以内的随机整数
            num1 = (float)new Random().NextDouble(); //num1的值为随机double类数值，因为方法定义的为float类型，此处强制转化
        }
    }
}
