using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    /// <summary>
    /// 委托的定义：
    ///     委托类型表示对具有特定参数列表和返回类型的方法的引用
    ///     通过委托，可以将方法视为可分配给变量并可作为参数传递的实体
    ///     委托类似于其他一些语言中的函数指针概念，但与函数指针不同的是，委托不仅面向对象，还类型安全
    ///     委托（Delegate）特别用于实现事件和回调方法。所有的委托（Delegate）都派生自 System.Delegate 类
    ///     一旦声明了委托类型，委托对象必须使用 new 关键字来创建，且与一个特定的方法有关     
    /// 
    /// 定义一个委托：
    ///     delegate <return type> <delegate-name> <parameter list>
    ///     无返回值的定义方法：public delegate void GetDele();
    ///     
    /// 定义委托类型的变量和赋值：
    ///      GetDele dele = s.Eat;
    ///      
    /// 委托的多播：
    ///     dele += s.Drink;
    ///     
    /// 委托的调用：
    ///     dele();
    /// </summary>
    public delegate void GetDele();
    class DelegateTest
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            GetDele dele = s.Eat; //直接将 对象的方法 的值 的地址 赋值 给 委托变量名
            dele += s.Drink;
            dele();
        }
    }

    class Student
    {
        public void Eat()
        {
            Console.WriteLine("吃东西");
        }

        public void Drink()
        {
            Console.WriteLine("喝水");
        }
    }
}
