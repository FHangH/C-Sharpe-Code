using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTree_v01
{
    class Magic : Role //魔法师（子类，继承Role），override Attack类
    {
        /// <summary>
        /// 创建一个目标指向父类Role的Magic方法，里面的参数name指向父类Role的参数name
        /// </summary>
        /// <param name="name">从Test类中，创建的Magic对象的参数传入，并指向父类</param>

        private int level;
        
        public int Level
        {
            set { level = value; }
            get { return level; }
        }

        public Magic(string name) : base(name)
        {

        }

        public Magic(string name, int level) : base(name)
        {
            this.level = level;
        }

        public override int Attack() //魔法师的攻击值
        {
            return 5 * level;
        }
    }
}
