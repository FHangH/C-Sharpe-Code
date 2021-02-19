using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTree_v01
{
    class Test
    {
        /// <summary>
        /// 创建Team对象
        /// 创建成员对象
        /// 调用AddMember（）将创建的角色添加到团队中
        /// 调用AttackSum（）求出团队成员的总攻击值
        /// 
        /// Role m1 = new Magic("温蒂");
        ///     调用Magic类创建对象m1 传递的参数 "温蒂" ，在原Magic类中，需要有个 传入参数name 的 构造方法Magic
        ///     在Magic类中创建一个Magic构造方法，且有一个传入参数name，但这条代码依然会报错
        ///     因为Magic类继承了Role类，而Role类中已经创建了一个Role类，且有一个传入参数name
        ///     子类的name 与 父类的name冲突，所以子类的方法后面添加 :base(name) 
        ///     意思为 传入name的参数值，指向父类参数name
        ///     修改后，这条代码就不会报错
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Team t1 = new Team();

            Role m1 = new Magic("温蒂", 8); //创建Magic对象
            Role m2 = new Magic("丽莎", 9);

            Role s1 = new Soldier("八重樱", 10); //创建Soldier对象
            Role s2 = new Soldier("芽衣", 10);
            Role s3 = new Soldier("白夜", 20);
            Role s4 = new Soldier("琴", 99);
            Role s5 = new Soldier("迪卢克", 20);

            t1.AddMember(m1); //将每一个成员添加到团队中
            t1.AddMember(m2);
            t1.AddMember(s1);
            t1.AddMember(s2);
            t1.AddMember(s3);
            t1.AddMember(s4);

            int result = t1.AttackSum();
            Console.WriteLine("战队" + "\t总攻击值: " + result + " AT");
        }
    }
}
