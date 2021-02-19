using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_ArrayList_Dictionnary.Demo2
{
    class DictionnaryDemo
    {
        /// <summary>
        /// Dictionary<TKey,TValue>  TKey,TValue用值类型
        /// Dictionary<TKey,TValue> 字典名 = new Dictionary<TKey,TValue>()
        /// Dictionary<int, string>.KeyCollection 此类不能继承
        /// Dictionary<int, string>.ValueCollection 此类不能继承
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Dictionary<int, string> roster = new Dictionary<int, string>(); //创建一个名为roster的字典
            roster.Add(752972182, "FH");
            roster.Add(1322976770, "CYL");

            Dictionary<int, string>.KeyCollection keys = roster.Keys; //获得roster字典理的键 KeyCollection是内部类
                                                                      //roster.Keys是获得字典的键
            Dictionary<int, string>.ValueCollection values = roster.Values; //获得roster字典里的值 ValueCollection是内部类
            
            Console.WriteLine("所有学生的id：");
            foreach (int id in keys) //keys是int类型的，所以遍历时的类型的int
            {
                Console.WriteLine("\t" + id);
            }

            Console.WriteLine("所有学生的name：");
            foreach (string name in values)
            {
                Console.WriteLine("\t" + name);
            }

            Console.WriteLine("查找花名册中是否有: " + roster[1322976770]);
            if (roster.ContainsKey(1322976770)) //roster.ContainsKey() 通过指定 字典内的键 来判断字典内是否含有该 键 的存在
            {
                Console.WriteLine("花名册中有：" + roster[1322976770]);
            }
            else
            {
                Console.WriteLine("Not found " + roster[1322976770]);
            }
        }
    }
}
