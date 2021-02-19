using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Attributes.Auto_Attributes //自动属性
{
    class Student
    {
        private string name;

        public string Name //标准属性
        {
            set
            {
                name = value;
            }

            get
            {
                return name;
            }
        }

        public int Number { set; get; } //自动属性
                                        //作用：当属性内，不需要进行判断等其他操作，仅仅只是传递参数和返回值
                                        //属性可以写成自动属性，也不需要写字段，直接写属性就可以了

    }
}
