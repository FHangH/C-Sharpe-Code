using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit.Test2
{
    class Rectangle : Graph
    {
        private double length; //长度
        private double width; //宽度

        public double Length
        {
            set { length = value; }
            get { return length; }
        }

        public double Width
        {
            set { width = value; }
            get { return width; }
        }

        public override double GetPerimeter()
        {
            return (length + width) * 2;
        }

        public override double GetArea()
        {
            return length * width;
        }
    }
}
