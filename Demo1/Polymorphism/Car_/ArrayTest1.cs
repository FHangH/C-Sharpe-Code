using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Car_
{
    /// <summary>
    /// 多态数组：
    ///     创建一个数组，存储4个Car类的数据，并将对应的元素存入数组中
    /// </summary>
    class ArrayTest1
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[4]; //创建一个动态初始化的数组

            Car c1 = new Audi("The Audi Car"); //准备一个Car类的对象c1，指向Audi类
            Car c2 = new Benz("The Benz Car");
            Car c3 = new BMW("The BMW Car");
            Car c4 = new Car("The Normal Car");

            cars[0] = c1; //将对象元素存入数组
            cars[1] = c2;
            cars[2] = c3;
            cars[3] = c4;

            foreach (Car c in cars) //遍历数组
            {
                c.Introduce(); //调用Introduce方法
            }
        }
    }
}
