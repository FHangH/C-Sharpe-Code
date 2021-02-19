using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo.List
{
    /// <summary>
    /// 集合中只包含一种数据类型的元素，则可以使用 System.Collections.Generic 命名空间中的一个类
    /// 泛型集合强制类型安全，因此无法向其添加任何其他数据类型
    /// 从泛型集合检索元素时，无需确定其数据类型或对其进行转换
    /// </summary>
    class ListTest
    {
        static void Main(string[] args)
        {
            List<PersonName> names = new List<PersonName>(); //创建List的容器names
            PersonName p1 = new PersonName("FH");
            PersonName p2 = new PersonName("CYL");

            names.Add(p1);
            names.Add(p2);

            foreach (PersonName name in names)
            {
                Console.WriteLine("Name: " + name.Name); 
            }

            Console.WriteLine("name集合的元素个数：" + names.Count);
        }
    }
}
