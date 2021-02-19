using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Car_
{
    class CarTest
    {
        /// <summary>
        /// 向上转型：父类的对象，指向子类
        /// 多态：
        ///     父类 对象 = new 子类;
        ///     对象.方法(); -- 编译期间 调用的方法是父类，如果父类virtual，子类override， 运行期间 调用的是子类
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Car car1 = new Audi(); //car1为父类的对象，指向子类，此过程为 向上转型 car1只能在 代码或编译期间）调用Car类的方法
                                   //但Car类的Introduce是virtual，所以car1可以在 （运行期间） 调用Audi自己重写的override方法
            car1.Introduce(); //此时代码期间调用的是父类，运行期间调用的是子类
            
            Car car2 = new Benz();
            car2.Introduce();
            
            Car car3 = new BMW();
            car3.Introduce();
        }
    }
}
