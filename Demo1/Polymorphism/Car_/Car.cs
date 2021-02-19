using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Car_
{
    /// <summary>
    /// 父类：
    ///     字段： 汽车品牌 (brand)
    ///     方法： 汽车介绍（构造方法）
    /// </summary>
    class Car 
    {
        private string brand;

        public string Brand //品牌
        {
            set { brand = value; }
            get { return brand; }
        }

        public Car() //无参构造方法
        {

        }

        public Car(string brand)
        {
            this.brand = brand; //以局部参数值赋给全局参数，父类和子类都需要添加 无参构造方法
        }

        public virtual void Introduce() //介绍
        {
            Console.WriteLine("Normal Car");
        }
    }
}
