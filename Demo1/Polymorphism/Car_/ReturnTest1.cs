using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Car_
{
    class ReturnTest1
    {
        static void Main(string[] args)
        {
            CarFactory fac = new CarFactory();          
            Car returnCar = fac.MadeCar("Audi Car!"); //调用MadeCar方法，传入字符参数
            returnCar.Introduce();
        }
    }
}
