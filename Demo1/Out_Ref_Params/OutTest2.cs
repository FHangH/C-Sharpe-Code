using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Ref_Params
{
    class OutTest2
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int sum, less;
            GetCalResult(out num1, out num2, out sum, out less);

            Console.WriteLine("a = " + num1);
            Console.WriteLine("b = " + num2);
            Console.WriteLine("a + b = " + sum);
            Console.WriteLine("a - b = " + less);
        }

        public static void GetCalResult(out int a, out int b, out int c, out int d)
        {
            a = 10;
            b = 20;
            c = a + b;
            d = a - b;
        }
    }
}
