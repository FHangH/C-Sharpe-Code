using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    class DelegateToEnum //通过委托完成 EnumTest的内容
    {
        public delegate void GetDele2();

        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            Student s = new Student();
            t.Notice(s.PlayGame);
        }

        public class Teacher
        {
            public void Notice(GetDele2 dele)
            {
                dele();
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
