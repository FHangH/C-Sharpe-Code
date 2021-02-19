using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Ref_Params
{
    class ParamsTest
    {
        static void Main(string[] args)
        {
            int sum = GetSum(1, 2, 3, 4);
            Console.WriteLine("Params : " + sum);
        }

        public static int GetSum(params int[] a) //params修饰后，Main方法中，直接在方法调用中传入想要计算的参数
        {
            int sum = 0;
            foreach(int i in a)
            {
                sum += i;
            }
            return sum;
        }
    }
}
