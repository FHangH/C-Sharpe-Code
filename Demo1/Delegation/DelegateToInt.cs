using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    public delegate void GetDele2(int a); //无返回值的委托
    class DelegateToInt
    {
        static void Main(string[] args)
        {
            GetDele2 dele2 = IntTo;
            int num = 10;
            dele2(num);
        }

        static void IntTo(int a)
        {
            Console.WriteLine(a);
        }
    }
}
