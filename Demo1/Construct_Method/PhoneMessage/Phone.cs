using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_Method.PhoneMessage
{
    class Phone
    {
        //两个私有化的字段
        private double price; 
        private float size;

        //为price字段添加两个间接的方法        
        //访问price字段的值
        public double GetPrice() //该方法的类型与字段price的类型相同，为double类型
        {
            return price;
        }
        //设置price字段的值
        /// <summary>
        /// 该方法的price为局部变量，this.price为Phone.cs类的全局变量
        /// price为double类型的形参，接收PhoneTest.cs内的实参，并赋值给全局变量price
        /// 因为局部变量名price和全局变量名price相同
        /// 所以，表达方式为: this.全局变量名 = 局部变量名
        /// </summary>
        /// <param name="price"></param>
        public void SetPrice(double price)
        {
            if (price < 0 || price > 1000000) //此处加一个判断，以满足传入实参后，返回不同的结果
            {
                Console.WriteLine("The phone price is wrrong!!!" + "\n" + "The price will be defult 1!!!");
                this.price = 1;
            }
            else
            {
                this.price = price;
            }
        }
    }
}
