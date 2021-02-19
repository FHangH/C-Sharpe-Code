using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_ArrayList_Dictionnary.Demo1
{
    class BookTest
    {
        /// <summary>
        /// List的方法使用：
        ///     1.Add() : 向集合中添加元素
        ///     2.Count : 统计集合中元素的个数
        ///     3.Insert() : 向集合中插入元素
        ///     4.Remove() : 去除集合中的元素
        ///     5.RemoveAt() : 去除集合中指定下标的元素
        ///     6.Clear() : 清空集合
        ///     7.ToArray() : 集合与数组的转换
        ///     8.Contains() : 判断集合中是否存在指定元素
        ///     9.Exists() : 判断指定元素是否在集合中
        /// 对集合的遍历：
        ///     for;
        ///     foreach;
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>(); //创建names容器

            Book book1 = new Book("Unity3D游戏开发", 89.00);
            Book book2 = new Book("Python基础", 78.80);

            books.Add(book1); //将Book对象book1 添加到容器books中
            books.Add(book2);
            
            //原有的书本数据
            Console.WriteLine("原有的书本数据：");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine("name: " + books[i].Name + "\t" + "price: " + books[i].Price + "￥"); //￥ 在中文输入法下输入 $
                                                                                                        //就可以自动转为 ￥
            }
            Console.WriteLine("现在books中有：" + books.Count + "本书");
            Console.WriteLine();

            //在第一位插入新书后
            Console.WriteLine("在第一位插入新书后：");
            Book book3 = new Book("C#基础", 99.80); //创建新的对象book3
            books.Insert(0, book3); //将book3 用Insert(下标，对象名) 插入到books集合的第一位
            foreach (Book book in books)
            {
                Console.WriteLine("name: " + book.Name + "\t" + "price: " + book.Price + "￥");
            }
            Console.WriteLine("现在books中有：" + books.Count + "本书");
            Console.WriteLine();

            //移除books中的第一本书
            Console.WriteLine("移除books中的第一本书：");
            bool result = books.Remove(book3); //同过 Remove()方法 将book3从books中移除
                                               //bool 变量名 = 集合名.Remove(books中的元素名)
            Console.WriteLine("移除" + book3.Name + ": " + result);
            Console.WriteLine("移除" + book3.Name + "后，现books中的书：");
            foreach (Book book in books)
            {
                Console.WriteLine("name: " + book.Name + "\t" + "price: " + book.Price + "￥");
            }
            Console.WriteLine("现在books中有：" + books.Count + "本书");
            Console.WriteLine();

            //从books中查找
            Console.WriteLine("从books中查找" + book3.Name + ":");
            bool result1 = books.Contains(book3); //通过 Contains()方法 判断集合中是否存在指定元素
                                                  //bool 变量名 = 集合名.Contains(books中的元素名)
            Console.WriteLine("books中查找" + book3.Name + "结果：" +result1);
            Console.WriteLine();

            //将集合的元素复制到一个数组中
            Console.WriteLine("将集合books的元素复制到一个数组中：");
            Book[] bookArray = books.ToArray(); //创建一个名为bookArray的Book类数组，通过books.ToArray()方法
                                                //数组名对应的类名[] 数组名 = 集合.ToArray()
            Console.WriteLine("得到集合值的数组中有：");
            foreach (Book book in bookArray)
            {
                Console.WriteLine("name: " + book.Name + "\t" + "price: " + book.Price + "￥");
            }
            Console.WriteLine();

            //清除集合中的元素
            Console.WriteLine("清除集合中的元素");
            books.Clear();
            Console.Write("清除后的集合中：");
            Console.WriteLine("现有" + books.Count + "本书");
            Console.WriteLine();
        }
    }
}
