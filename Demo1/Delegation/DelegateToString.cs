using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    class DelegateToString //有返回值的委托
    {
        public delegate string GetDele(string str);

        static void Main(string[] args)
        {
            string strup = StringTo(StringToUp, "FHang");
            Console.WriteLine(strup);

            string strlower = StringTo(StringToLower, "FHANG");
            Console.WriteLine(strlower);
        }

        public static string StringTo(GetDele dele, string str)
        {
            return dele(str);
        }
        static string StringToUp(string str)
        {
            return str.ToUpper();
        }

        static string StringToLower(string str)
        {
            return str.ToLower();
        }
    }

}
