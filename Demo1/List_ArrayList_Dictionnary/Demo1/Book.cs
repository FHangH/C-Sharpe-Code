using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_ArrayList_Dictionnary.Demo1
{
    class Book
    {
        private string name;
        private double price;

        public string Name { get => name; set => name = value; } //生成属性快捷键：选中要生成属性的字段，Ctrl + R + E
        public double Price { get => price; set => price = value; }

        public Book()
        {

        }

        public Book(string name, double price)
        {
            this.name = name;
            this.price = price;
        } 


    }
}
