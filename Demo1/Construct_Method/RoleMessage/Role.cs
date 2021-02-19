using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_Method.RoleMessage
{
    class Role
    {
        public string name; //角色名称
        public int age; //角色年龄
        public string sex; //角色性别
        public int level; //角色等级

        public Role()
        {
            //无参数演示
        }

        public Role(string RoleName, string RoleSex, int RoleAge, int RoleLevel) //构造方法演示
        {
            name = RoleName; //this.name = name 效果相同,将局部变量name值赋值给全局变量name
            sex = RoleSex;
            age = RoleAge;           
            level = RoleLevel;
        }
        public int Attack()
        {
            return level * 3;
        }

    }

}
