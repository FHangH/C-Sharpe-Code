using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Class1 //完成类
    {
        static void Main(string[] args)
        {
            Elephant e1 = new Elephant(); //e1 是Elephant类创建的对象，它包含了Elephant类中的全局变量，并可以调用
            e1.name = "CYL";
            e1.sex = "Girl";
            e1.age = 20;

            IceBox box1 = new IceBox();
            box1.number = 666;
            box1.price = 6488;
            box1.subsidy = true;

            Console.Write("elephant message : " + "\n" + "\t");
            Console.Write("elephant's name is " + e1.name + "\n" + "\t"
                + "elephant's sex is " + e1.sex + "\n" + "\t"
                + "elephant's age is " + e1.age + "\n");
            Console.Write("\n" + "\t");
            e1.Eat();
            Console.Write("\t");
            e1.Show();
            Console.WriteLine();

            Console.Write("icebox message : " + "\n" + "\t");
            Console.Write("icebox's number is " + box1.number + "\n" + "\t"
                + "icebox's price is " + box1.price + "\n" + "\t"
                + "icebox's subsidy is " + box1.subsidy + "\n" + "\t");
            Console.WriteLine();

            Console.Write("\t");
            Console.Write("First we need ");
            box1.OpenDoor();
            Console.Write("\t");
            Console.Write("Second we ");
            box1.InPut();
            Console.Write("\t");
            Console.Write("Last we ");
            box1.CloseDoor();
        }
    }

    class Elephant //大象类
    {
        /// <summary>
        /// 字段：对类的特征进行描述（全局变量）
        /// </summary>
        public string name; //名字
        public string sex; //性别
        public int age; //年龄 
        public string kind; //种类
        public float height; //身高
        public double weight; //体重
        public bool marriage; //婚否

        /// <summary>
        /// 行为：类可以完成某种功能
        /// </summary>
        public void Eat() //吃
        {
            Console.WriteLine("elephant is like eat grass!");
        }

        public void Show() //表演
        {
            Console.WriteLine("elephant is like show play ball!");
        }
        
    }

    class IceBox
    {
        public double price; //价格
        public string brand; //品牌
        public string color; //颜色
        public int number; //编号
        public bool subsidy; //补贴

        public void OpenDoor() //开门
        {
            Console.WriteLine("Open the door");
        }

        public void InPut() //放入
        {
            Console.WriteLine("Put elephant in IceBox");
        }

        public void CloseDoor() //关门
        {
            Console.WriteLine("Close the door");
        }
    }
}
