using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    //定义委托
    public delegate bool Dele<T>
        (T num1, T num2);
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p.GetTemp<int>(20,10);
            //p.GetTemp(20.5f, 10.3f);
            ////p.GetTemp("a","b");
            p.Getmax((a, b) =>
            {
                int sum = a - b;
                bool isB = false;
                if (sum > 0)
                {
                    isB = false;
                }
                if (sum < 0)
                {
                    isB = true;
                }
                return isB;
            }
            , 1, 2, 3, 4, 5, 6);

        }
    }

    public class Person
    {
        //泛型的约束：T ：Struct【值类型】
        public void GetTemp<T>(T a, T b)
            where T : struct
        {
            T temp = a;
            a = b;
            b = temp;
        }
        //排序方法
        public void Getmax<T>(Func<T, T, bool> del, params T[] nums)
        {
            T max = nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    //缺少一个比较的方法
                    //if(max<nums[j])
                    if (del(nums[j], nums[j + 1]))
                    {
                        T temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;

                    }
                }
            }
        }
        /* 自定义泛型的约束
         *  T ：struct    限定T类型只能为值类型
         *  Q : class     限定Q类型为引用类型
         *  O ：ICloneable 只能是ICloneable的子类；
            K ：Person    限定K类型只能为
                          Person或者Person的子类
         *  W : class,new() 限定w类型是引用类型
         *                并且使用了无参构造函数
         */
    }
}
