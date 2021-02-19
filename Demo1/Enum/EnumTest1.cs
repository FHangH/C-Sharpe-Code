using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class EnumTest1
    {
        /// <summary>
        /// 枚举是值类型，它包含自己的值，且不能继承和传递继承
        /// 枚举小标从0开始,枚举类型的值在未定义的情况下，默认为int类型
        /// 调用枚举时，定义值类型
        /// 枚举语法：
        ///     enum 枚举名 : 类型 (默认为int)
        ///     {
        ///         枚举项0，
        ///         枚举项1，
        ///         .......
        ///     }
        ///     
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //直接调用枚举，不定义类型，直接打印选择调用的枚举值
            Console.WriteLine();
            Console.WriteLine("不定义类型，调用未赋值的枚举项");
            Console.WriteLine(Sex.man);
            Console.WriteLine(Sex.woman);
            Sex sex4 = Sex.man;
            Sex sex5 = Sex.woman;
            Console.WriteLine("sex4: " + sex4);
            Console.WriteLine("sex5: " + sex5);
            Console.WriteLine();

            /// <summary>
            /// 调用时，定义枚举类型，则打印对应类型的值
            /// 定义int类型时，从枚举中一个值开始调用，打印的值也从0开始
            /// 定义类型：类型 变量名 = (类型)枚举名.枚举项
            ///     int sex = (int)Sex.man
            /// </summary>
            int sex = (int)Sex.man;
            int sex1 = (int)Sex.woman;
            Console.WriteLine("定义类型，调用未赋值的枚举项");
            Console.WriteLine("sex: " + sex);
            Console.WriteLine("sex1: " + sex1);
            Console.WriteLine();

            //调用被赋值的枚举项
            int sex2 = (int)Sex.male;
            int sex3 = (int)Sex.female;
            Console.WriteLine("定义类型，调用赋值后的枚举项");
            Console.WriteLine("sex2: " + sex2);
            Console.WriteLine("sex3: " + sex3);
            Console.WriteLine();
        }

        /// <summary>
        /// 定义一个 性别相关的枚举
        /// 该枚举未标明类型，所以默认int类型
        /// 枚举项为赋值，则默认以int类型，从0开始一次赋值，赋值不能重复
        /// 赋值后的枚举项，被调用时，打印被赋的值（赋值范围为int类型）
        /// </summary>
        enum Sex : int //默认int类型
        {
            man, woman, male = 10, female = 20
        }
        

    }
}
