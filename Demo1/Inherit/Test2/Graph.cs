using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit.Test2
{
    class Graph //图形
    {
        private string name;

        public string Name //标准属性：名字
        {
            set{ name = value; }
            get{ return name; }
        }

        public virtual double GetPerimeter() //定义成一个virtual的类，用于被子类重写
        {
            return 0.0;
        }

        public virtual double GetArea()
        {
            return 0.0;
        }
    }
}
