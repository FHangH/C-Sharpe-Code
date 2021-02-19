using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTree_v01
{
    class Role //角色类（父类）
    {
        private string roleName;

        public string RoleName //构建一个角色名标准属性
        {
            set { roleName = value; } //——接收到Role方法的name值，被value赋值给roleName，可用于逻辑判断
            get { return roleName; }
        }

        public Role() //无参数方法
        {

        }

        public Role(string name) //角色命名方法
        {
            //RoleName = name; //将传入的参数赋值给RoleName属性——
            roleName = name;
        }

        public virtual int Attack() //构建一个virtual的int类型的Attack方法，用于当作父类的方法，被继承的子类override
        {
            return 0;
        }
    }
}
