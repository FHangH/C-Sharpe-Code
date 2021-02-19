using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class ForeachArray //foreach（数组类型[] 变量名 in 数组名）{} 
                       //foreach可以将数组中的元素遍历赋值给变量
    {
        static void Main(string[] args)
        {
            string[] rolenames = { "Fh", "Cyl" }; //定义一个字符元素的数组

            foreach (string names in rolenames) //变量名为name，遍历rolename内的所有数组元素
            {
                Console.WriteLine(names);
            }
        }
    }
}
