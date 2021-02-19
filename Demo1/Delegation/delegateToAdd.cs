using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    //创建一个委托
    public delegate void GetDeleAdd();
    class delegateToAdd
    {
        static void Main(string[] args)
        {
            //定义一个委托变量
            GetDeleAdd deleAdd;
            //委托的多播——绑定方法
            deleAdd = Test;
            deleAdd += LookTest;
            deleAdd += MoveTest;

            //委托的多播——解除方法绑定
            deleAdd -= MoveTest;

            //调用委托
            deleAdd();
        }

        static void Test()
        {
            Console.WriteLine("测试");
        }

        static  void LookTest()
        {
            Console.WriteLine("看看");
        }

        static  void MoveTest()
        {
            Console.WriteLine("走走");
        }
    }
}
