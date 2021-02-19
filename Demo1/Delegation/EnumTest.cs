using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    /// <summary>
    /// 利用枚举完成
    /// 
    /// 假设有1000方法要用，就需要写1000个方法，太繁琐
    /// 再用委托完成 —— DelegateToEnum
    /// </summary>
    class EnumTest
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            t.Notice(Mode.playgame);
        }

        public enum Mode
        {
            playgame,
            drink,
            talktogirl
        }

        public class Teacher
        {
            public void Notice(Mode m)
            {
                Student s = new Student();
                switch (m)
                {
                    case Mode.playgame: s.PlayGame();
                        break;

                    case Mode.drink: s.Drink();
                        break;

                    case Mode.talktogirl: s.TalktoGirl();
                        break;
                }
            }
        }

        public class Student
        {
            public void PlayGame()
            {
                Console.WriteLine("玩游戏");
            }

            public void Drink()
            {
                Console.WriteLine("喝水");
            }

            public void TalktoGirl()
            {
                Console.WriteLine("聊天");
            }
        }
    }


}
