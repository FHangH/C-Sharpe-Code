using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Car_
{
    class Person
    {
        public void Drive(Car c) //参数类型为父类，即可创建多态参数方法
        {
            Console.Write("Person1 Drive: ");
            c.Introduce();
        }
    }
}
