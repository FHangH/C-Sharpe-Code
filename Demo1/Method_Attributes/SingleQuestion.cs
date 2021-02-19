using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Attributes //属性
{
    class SingleQuestion 
    {
        //私有字段
        private int number; //题号
        private string text; //题目
        private string[] options; //选项
        private string answer; //答案

        /// <summary>
        /// 属性语法：
        /// public 对应字段类型 属性名（最好字段的首字母大写）
        /// {
        ///     set //设置对应字段值
        ///     {
        ///         字段名 = value;
        ///     }
        ///     
        ///     get //访问对应字段设置后的值
        ///     {
        ///         return 字段名;
        ///     }
        /// }
        /// </summary>
        public int Number //题号
        {
            set
            {
                number = value; //value是系统默认的变量名，并赋值给当前操作的字段number
                                //set是属性Number的一个方法，value等于形参，传入实参后赋值给字段变量名number
                                //赋值后的字段变量名number，被get调用
                                //value的值类型，与对应字段的类型一致
            }

            get
            {
                return number;
            }
        }

        public string Text //题目
        {
            set
            {
                text = value;
            }

            get
            {
                return text;
            }
        }

        public string[] Options //选项
        {
            set
            {
                options = value; //此处value传入的值为Test类中定义的数组遍历出来的数组元素
            }

            get
            {
                return options;
            }
        }

        public string Answer //答案
        {
            set
            {
                answer = value;
            }

            get
            {
                return answer;
            }
        }

        public bool Check(string input) //选择
        {
            if (input.Equals(answer, StringComparison.CurrentCultureIgnoreCase)) //Equal(需要比较是否相同的string)
                                                                                 //StringComparison.CurrentCultureIgnoreCase
                                                                                 //可以忽略输入字母的大小写
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
