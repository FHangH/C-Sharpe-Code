using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest2
{
    public delegate void DamageEventHandler(DamageEventArgs args);

    class Test1
    {
        static void Main(string[] args)
        {
            MainCity mainCity = new MainCity() { HP = 100, MaxHP = 100, Name = "天庭" };
            mainCity.GetDamage += Alarm.OpenAlarm;
            mainCity.GetDamage += Wall.WallUpGarde;
            mainCity.Damage(10);
        }
    }

    public class DamageEventArgs //事件的基类 args是基类的参数
    {
        public object Sender { get; set; } //事件源
        public float LifeNum { get; set; }
    }

    public class MainCity //事件发布者
    {
        public float HP { get; set; }
        public float MaxHP { get; set; }
        public string Name { get; set; }

        public event DamageEventHandler GetDamage; //定义一个事件

        public void Damage(float val)
        {
            HP -= val;

            if (GetDamage == null) return;
            DamageEventArgs args = new DamageEventArgs() 
            {
                Sender = this,
                LifeNum = 1 - (HP / MaxHP)
            };

            GetDamage(args);
        }
    }

    public class Alarm //响应者
    {
        public static void OpenAlarm(DamageEventArgs args) //标签与基类一致
        {
            Console.WriteLine("{0}级警报", args.LifeNum * 10);
        }
    }

    public class Wall //响应者
    {
        public static void WallUpGarde(DamageEventArgs args)
        {
            MainCity mainCity = args.Sender as MainCity; //将MainCity的类型转换成事件源类型
            Console.WriteLine("{0}城墙升级", mainCity.Name);
        }
    }
}
