using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Car_
{
    /// <summary>
    /// 子类
    /// </summary>
    class Benz : Car
    {
        public Benz() //无参构造方法
        {

        }
        public Benz(string brand) : base(brand)
        {

        }

        public override void Introduce()
        {
            Console.WriteLine("Benz Car");
        }
    }
}
