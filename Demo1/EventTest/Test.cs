using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    class Test
    {
        public delegate void GetDele();
        static void Main(string[] args)
        {
            //新建对象
            Alarm getAlarm = new Alarm();
            Solder getSolder = new Solder();
            Wall getWall = new Wall();
            //实例化主城，和初始属性状态
            MainCity mainCity = new MainCity() { HP = 100, MaxHP = 100 };

            //给事件绑定方法
            mainCity.Start += getAlarm.OpenAlarm;
            mainCity.Start += getSolder.UpgradeSolder;
            mainCity.Start += getWall.UpgradeWall;
            //受到伤害，触发Damage方法，并修改属性值，触发Start（）事件
            mainCity.Damage(7);
        }
    }
}
