using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTree_v01
{
    /// <summary>
    /// 字段；Role[] roles 
    /// 方法：AddMember(Role r) 给团队添加成员
    ///       AttackSum() 统计团队成员的攻击值总和
    /// </summary>
    class Team //团队类
    {
        Role[] roles = new Role[6]; //创建一个动态数组，用于存储成员
        int count = 0; //数组下标初始化为0
        int sum = 0; //成员总攻击值初始化为0

        /// <summary>
        /// 给团队添加成员
        /// </summary>
        /// <param name="r">添加进团队的成员</param>
        public void AddMember(Role r)
        {
            roles[count] = r; //将传入的参数值，也就是成员，存入数组
            count++; //没存入一个成员，下标自动加1，用于存储下一个成员
            if (count == 6)
            {
                Console.WriteLine("战队成员已满！");
                return;
            }
            else if(roles.Length < 5)
            {
                Console.WriteLine("战队成员未满！");
                return;
            }
        }

        /// <summary>
        /// 统计团队成员的攻击值总和
        /// </summary>
        /// <returns>攻击值总和</returns>
        public int AttackSum()
        {
            for (int i = 0; i < roles.Length; i++)
            {
                int roleAttack = roles[i].Attack(); //每遍历出一个成员，会根据他的属性返回一个攻击值到roleAttack中
                Console.WriteLine(roles[i].RoleName + "\t攻击力：" + roleAttack + " AT");
                sum += roleAttack; //将所有成员的Attack值相加
            }
            return sum; //返回团队成员的攻击值总和
        }
    }
}
