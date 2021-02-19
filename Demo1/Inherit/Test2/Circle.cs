using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit.Test2
{
    class Circle : Graph
    {
        private double radius;
        
        public double Radius //标准属性：半径
        {
            set { radius = value; }
            get { return radius; }
        }

        public override double GetPerimeter() //重写了Graph类中的GetPerimeter方法，并返回给GraphTest类中进行调用
        {
            return 2 * Math.PI * radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2); //Math.Pow(数组，次方) ：用于求某个数值的次方
        }
    }
}
