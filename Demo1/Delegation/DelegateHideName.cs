using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    /// <summary>
    /// 匿名函数：给委托赋值时，该方法只使用一次，可以通过delegate关键字，写成匿名函数
    ///     delegate(){}
    /// </summary>
    /// 

    public delegate string GetDele3(string str);
    public delegate int GetDele4(int num1, int num2);
    class DelegateHideName
    {
        static void Main(string[] args)
        {
            GetDele3 dele3 = delegate (string str) { return str.ToUpper(); };
            string str2 = dele3("FHang");
            Console.WriteLine(str2);

            int number = NumTest(delegate (int num1, int num2) { return num1 - num2; }, 4, 8);
            Console.WriteLine(number);
        }

        static int NumTest(GetDele4 dele4, int num1, int num2)
        {
            return dele4(num1, num2);
        }
    }
}
