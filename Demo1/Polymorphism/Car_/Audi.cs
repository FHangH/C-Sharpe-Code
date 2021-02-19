using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Car_
{
    class Audi : Car
    {
        public Audi() //无参构造方法
        {

        }

        public Audi(string brand) : base(brand) //brand是父类的参数，不可用this.brand = brand
                                                //采用 :base(brand)
        {

        }

        public override void Introduce()
        {
            Console.WriteLine("Audi Car");
        }
    }
}
