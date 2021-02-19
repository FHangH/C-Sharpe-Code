using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    public delegate void GetDeleA();
    public delegate void GetDeleB(string str);
    public delegate string GetDeleC(string str);

    class DelegateLamda
    {
        static void Main(string[] args)
        {
            //委托
            GetDeleA delea = delegate () { };
            GetDeleB deleb = delegate (string str) { Console.WriteLine("hello,world"); };
            GetDeleC delec = delegate (string name) { name = name.ToUpper(); return name; };

            //Lamda表达式
            GetDeleA deleA = () => { };
            GetDeleB deleB = (str) => { Console.WriteLine("hello,world"); };
            GetDeleC deleC = (name) => { name = name.ToUpper(); return name; };
        }
    }
}
