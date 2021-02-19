using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload //方法重载
{
    /// <summary>
    /// 方法重载的使用条件：
    ///     一个类中，有一组相同命名的方法（至少有两个方法，才算重载）；
    /// 方法重载的定义和运行原理：
    ///     方法重载是一种作用机制，可以在一个类中定义多个相同的方法名；
    ///     方法的参数列表可以不同（参数类型，参数个数）；
    ///     调用编译器时，会根据实际传入的参数，进行自动匹配方法；
    /// 方法重载的使用方法：
    ///     在同一个类下，如本例：MethodOverload_IndexAdd和Overload_Add在一起；
    ///     此时在MethodOverload_IndexAdd中调用Overload_Add中的方法时，Overload_Add类名前，不用加public；
    ///     如果不在同一个类下时，Overload_Add前需要加入public，MethodOverload_IndexAdd才有足够的权限调用；
    ///     
    ///     调用Overload_Add类中的方法Add时，要在方法前加入public，才能调用；
    /// </summary>
    class MethodOverload_IndexAdd //重载的测试
    {
        static void Main(string[] args)
        {
            Random r = new Random(); //设置随机数作为调用的参数

            int a = r.Next(-100000000, 100000000); //Next(minValue, maxValue)；控制随机整数的取值范围
            int b = r.Next(-100000000, 100000000);

            float f1 = (float)r.NextDouble(); //(float为强制类型转化)
            float f2 = (float)r.NextDouble();

            double d1 = r.NextDouble();
            double d2 = r.NextDouble();

            Console.WriteLine();
            Console.WriteLine("************Method Overload************");
            Console.WriteLine();
            Console.Write("两个随机的int数相加：" + a + " + " + b + " = " + " ");
            Console.WriteLine(Overload_Add.Add(a, b));
            Console.WriteLine();

            Console.Write("两个随机的float数相加：" + f1 + " + " + f2 + " = " + " ");
            Console.WriteLine(Overload_Add.Add(f1, f2));
            Console.WriteLine();

            Console.Write("两个随机的double数相加：" + d1 + " + " + d2 + " = " + " ");
            Console.WriteLine(Overload_Add.Add(d1, d2));
            Console.WriteLine();
        }
    }

    class Overload_Add //方法重载工具：这个类中有多个方法（都定义成静态）
    {
        /// <summary>
        /// 该方法是一个int类型的Add
        /// </summary>
        /// <param name="a">第一个参数</param>
        /// <param name="b">第二个参数</param>
        /// <returns>返回一个int类的数</returns>
        public static int Add(int a, int b) //两个int类型的数相加
        {
            return a + b;
        }

        /// <summary>
        /// 该方法是一个float类型的Add
        /// </summary>
        /// <param name="a">第一参数会自动转化为float类型</param>
        /// <param name="b"></param>
        /// <returns>返回一个float类型的数</returns>
        public static float Add(int a, float b) //int a自动转化成float类型
        {
            return a + b;
        }

        /// <summary>
        /// 该方法是一个double类型的Add
        /// 如果参数是int类型或者float类型，则自动转化为double类型
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>返回一个double类型的数</returns>
        public static double Add(double a, double b) //两个double类型的数相加
        {
            return a + b;
        }
    }
}
