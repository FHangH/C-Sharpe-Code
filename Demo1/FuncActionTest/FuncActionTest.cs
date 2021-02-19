using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionTest
{
    class FuncActionTest
    {
        static void Main(string[] args)
        {
            //Func是带有返回值的泛型委托，必须最后一个参数为返回值
            //Func<参数（可有可无），返回值类型> 委托变量名 = （形参）=> { return xxxx;};

            //无参数，只有一个返回值的Func
            Func<int> dele = () => { return 9; };
            dele();
            //有两个参数，一个返回值的Func
            Func<int, int, bool> deleA = (a, b) => { return true; };
            deleA(1, 2);
            //一个参数，一个返回值的Func
            Func<string, string> deleB = (string str) => { return str; };
            deleB("FHang");

            //Action是不带返回值，只带参数类型的泛型委托
            //Action<参数1，.....> 委托变量名 = (形参) => {方法体;};

            //有一个参数的Action
            Action<int> deleC = (a) => { Console.WriteLine(a); };
            deleC(10);
            //有两个参数的Action
            Action<int, float> deleD = (num1, num2) => { Console.WriteLine(num1 + num2); };
            deleD(10, 11f);

        }
    }
}
