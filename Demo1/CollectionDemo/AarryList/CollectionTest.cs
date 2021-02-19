using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //导入引用，包含ArrayList方法

namespace CollectionDemo
{
    class CollectionTest //集合
    {
        /// <summary>
        /// 集合是一个类，因此必须在向该集合添加元素之前，声明类的实例
        /// 集合和数组的区别：
        ///     数组最适用于创建和使用固定数量的强类型化对象
        ///     集合提供更灵活的方式来使用对象组 与数组不同，你使用的对象组随着应用程序更改的需要动态地放大和缩小
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(); //ArrayList类型的可以放入任何类型的数据
            Collection_Car c1 = new Collection_Car("FH");
            Collection_Car c2 = new Collection_Car("CYL");
            Collection_Car c3 = new Collection_Car("FHang");

            list.Add(c1);
            list.Add(c2);
            list.Add(c3);

            foreach (Collection_Car car in list)
            {
                Console.WriteLine("Car name: " + car.Name);
            }
        }
    }
}
