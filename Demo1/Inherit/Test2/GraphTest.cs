using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit.Test2
{
    /// <summary>
    /// 子类继承了父类所有的内容，但无法访问父类中的private
    /// 子类无法继承父类的构造方法，但可以调用
    /// 子类后面默认的又一个 :base() 先继承父类的无参数构造方法，再调用其他的方法
    /// :base(参数) 参数的类型和个数决定了调用父类中的某个方法
    /// 子类 重写了父类之后，如果需要 调用父类 中的某个成员，可以使用：base.父类方法名（成员） 
    /// 
    /// 关键字：
    ///     virtual语法:允许子类重写父类方法或属性（无法修饰使用static修饰的成员） 
    ///      修饰属性：public virtual 数据类型 属性名{set; get;}
    ///      修饰方法：访问修饰符 virtual 返回值类型 方法名
    ///                 {
    ///                 }
    ///     
    ///     override：当子类不满足于父类的方法时，可以自己重写
    ///         访问修饰符 override 返回值类型 方法名
    ///                 {
    ///                 }
    ///     
    ///     new：当父类和子类都有完成相同功能的方法时，子类不想使用父类的方法，此时使用new关键字
    ///         访问修饰符 new 返回值类型 方法名
    ///                 {
    ///                 }
    /// </summary>
    class GraphTest
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(); //创建一个c1对象，调用Circle类中的方法

            Console.WriteLine(c1.Name = "Circle 1:"); //Circle类中没有Name方法，但继承了Graph类中的标准属性
            c1.Radius = 12.2; //给Circle类中的标准属性传入实参
            Console.WriteLine("Radius: " + c1.Radius + "cm");
            Console.WriteLine("\t" + "Circle Perimeter: " + c1.GetPerimeter() + "cm");
            Console.WriteLine("\t" + "Circle Area: " + c1.GetArea() + "cm^2" + "\n");

            Console.WriteLine("*************** split line ***************" + "\n");

            Rectangle r1 = new Rectangle();

            Console.WriteLine(r1.Name = "Rectangle 1:");
            r1.Length = 66.0;
            r1.Width = 33.0;
            Console.WriteLine("Length: " + r1.Length + "cm" + "\n" + "Width: " + r1.Width + "cm");
            Console.WriteLine("\t" + "Rectangle Perimeter: " + r1.GetPerimeter() + "cm");
            Console.WriteLine("\t" + "Rectangle Area: " + r1.GetArea() + "cm^2");
        }
    }
}
