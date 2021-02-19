using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Car_
{
    class BMW : Car
    {
        public BMW() //无参构造方法
        {

        }

        public BMW(string brand) : base(brand)
        {

        }

        public override void Introduce()
        {
            Console.WriteLine("BMW Car");
        }
    }
}
