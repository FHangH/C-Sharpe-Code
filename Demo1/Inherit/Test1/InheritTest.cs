using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    /// <summary>
    /// 继承（语法）：
    ///     class 子类 ： 父类
    ///     {
    ///     }
    /// 继承是单层继承
    /// 继承具有传递性：
    ///     class A {}
    ///     class B : A {}
    ///     class C : B {}
    /// </summary>
    class InheritTest
    {
        static void Main(string[] args)
        {
            SonClass s1 = new SonClass();
            s1.GrandFarther(); //父类FartherClass将继承的GrandFartherClass类传递给SonClass类
            s1.Farther();

        }
    }
}
