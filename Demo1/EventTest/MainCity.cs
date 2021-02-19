using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest //事件只能从事件的发起者调用
{
    class MainCity
    {
        //定义一个没有返回值的事件Start
        public event Action Start;

        //定义两个自动属性
        public float HP { get; set; }
        public float MaxHP { get; set; }

        //定义一个主城受到伤害时触发的Damage方法
        public void Damage(float val)
        {
            HP -= val;
            //受到伤害后，调用事件
            Start();
        }
    }
}
