using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_Method.RoleMessage
{
    class RoleTest
    {
        static void Main(string[] args)
        {
            Role role1 = new Role(); //无参数演示

            Role role2 = new Role(); //通过 对象名.字段 = 赋值 演示
            role2.name = "FH";
            role2.sex = "Man";
            role2.age = 20;
            role2.level = 100;
            //访问role2对象的字段值
            Console.WriteLine("Role2 Messages: " + "\t");
            Console.WriteLine("\t" + "RoleName; " + role2.name);
            Console.WriteLine("\t" + "RoleSex: " + role2.sex);
            Console.WriteLine("\t" + "RoleAge: " + role2.age);
            Console.WriteLine("\t" + "RoleLevel: " + role2.level);
            //访问role2的Attack（）方法
            Console.WriteLine("\t" + "RoleAttack: " + role2.Attack());

            Role role3 = new Role("CYL", "Woman", 20, 10); //通过构造方法演示
            Console.WriteLine("Role3 Messages: " + "\t");
            Console.WriteLine("\t" + "RoleName: " + role3.name);
            Console.WriteLine("\t" + "RoleSex: " + role3.sex);
            Console.WriteLine("\t" + "RoleAge: " + role3.age);
            Console.WriteLine("\t" + "RoleLevel: " + role3.level);
            Console.WriteLine("\t" + "RoleAttack: " + role3.Attack());
        }
    }
}
