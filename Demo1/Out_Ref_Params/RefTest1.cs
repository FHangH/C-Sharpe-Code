using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Ref_Params
{
    class RefTest1
    {
        /// <summary>
        /// ref 修饰的参数传递前需要先赋值
        /// 参数的值传递到其他方法操作后，ref修饰的参数值会修改
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = 1000;
            Change1(ref a);
            Console.WriteLine("ref :" + a); //在未经过ref修饰参数前，打印结果为Main方法内的a值
        }

        public static void Change1(ref int a1)
        {
            a1 = 20;
        }
    }
}
