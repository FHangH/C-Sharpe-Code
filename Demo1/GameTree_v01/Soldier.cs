using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTree_v01
{
    class Soldier : Role //战士(子类，继承Role)
    {
        /// <summary>
        /// 创建一个目标指向父类Role的Soldier方法，里面的参数name指向父类Role的参数name
        /// </summary>
        /// <param name="name">从Test类中，创建的Soldier对象的参数传入，并指向父类</param>
        /// 

        private int level;

        public int Level
        {
            set { level = value; }
            get { return level; }
        }

        public Soldier (string name) : base(name)
        {

        }

        public Soldier (string name, int level) : base(name)
        {
            this.level = level;
        }
        public override int Attack()
        {
            return 8 * level;
        }
    }
}
