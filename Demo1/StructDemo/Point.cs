using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    /// <summary>
    /// 结构：
    ///     struct 结构名
    ///     {
    ///     }
    ///     
    /// 结构是值类型，包涵大部分类类型的内容，但不支持无参数构造方法
    /// 结构类型不支持用户指定的继承
    /// 
    /// 结构是值类型，不需要使用 new关键字 来创建对象
    /// 类与结构创建对象的区别：
    ///     类： class Point {}   Point p1 = new Point()
    ///     结构： struct Point {}  Point p2  
    ///     
    /// 类和结构的使用区别：
    ///     1. 需要描述的对象比较复杂时，使用类
    ///     2. 描述轻量级或少量有含义的内容时，使用结构
    ///     {
    ///         结构对包含值语义的小型数据结构特别有用。 
    ///         复数、坐标系中的点或字典中的键值对都是结构的典型示例。 
    ///         对小型数据结构使用结构（而不是类）在应用程序执行的内存分配次数上存在巨大差异。
    ///     }
    ///     
    /// </summary>
    struct Point
    {
        private int x;

        public int X
        {
            set { x = value; }
            get { return x; }
        }

        public void Print()
        {
            Console.WriteLine("This is a Point class");
        }

        public Point(int x)
        {
            this.x = x;
        }
    }
}
