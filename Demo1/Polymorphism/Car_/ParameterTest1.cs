using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Car_
{
    class ParameterTest1 //多态参数
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(); //创建一个Person对象p1
            Car c = new Audi(); //创建一个 指向子类Audi 的 父类Car对象c
            p1.Drive(c); //调用Drive方法，传递参数为重写的子类Audi的Introduce方法
        }
    }
}
