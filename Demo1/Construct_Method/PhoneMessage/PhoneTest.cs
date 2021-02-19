using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_Method.PhoneMessage
{
    class PhoneTest
    {
        static void Main(string[] args)
        {
            Phone p1 = new Phone();

            //为p1对象price的字段值进行设置
            p1.SetPrice(10000000);
            //访问p1对象price的字段值
            Console.WriteLine("Phone Price: " + p1.GetPrice() + "$");
        }
    }
}
