using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Car_
{
    class CarFactory
    {
        public Car MadeCar(string carName)
        {
            Car c1 = new Audi("Audi Car!"); //创建多态参数方法
            Car c2 = new Benz("Benz Car!");
            Car c3 = new BMW("BMW Car!");
            Car c4 = new Car("Normal Car!");

            if (carName.Equals(c1.Brand)) //从ReturnTest中传入的字符参数与已经创建好的多态字符参数进行对比
            {
                Console.WriteLine("Graduation is Audi Car！"); //模拟提示要写在return上面，因为return之后，这一段程序就结束了
                                                               //return语句要放在最后
                return c1;               
            }
            else if (carName.Equals(c2.Brand))
            {
                return c2;
            }
            else if (carName.Equals(c3.Brand))
            {
                return c3;
            }
            else
            {
                return c4;
            }
        }
    }
}
