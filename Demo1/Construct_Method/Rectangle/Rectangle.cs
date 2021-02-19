using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_Method.Rectangle
{
    class Rectangle //矩形
    {
        private double width; //宽度
        private double height; //高度

        public double GetHeight() //获取高度
        {
            return height;
        }
        public void SetHeight(double height) //设置高度
        {
            this.height = height;
        }

        public double GetWidth() //获取宽度
        {
            return width;
        }
        public void SetWidth(double width) //设置宽度
        {
            this.width = width;
        }

        public Rectangle(double height, double width) //设置矩形的长和宽的局部形参并赋值给字段全局变量名
        {
            this.height = height;
            this.width = width;
        }
        public double Perimeter() //获取周长
        {
            return (height + width) * 2;
        }
        public double Area() //获取面积
        {
            return height * width;
        }
    }
}
