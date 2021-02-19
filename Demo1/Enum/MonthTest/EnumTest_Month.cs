using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum.MonthTest
{
    class EnumTest_Month
    {
        static void Main(string[] args)
        {
            Month m = Month.October; //通过枚举名创建一个对象，并用过 枚举名.枚举项 调用值
            Console.WriteLine(m);
            
            string n = ChooseMonth(m);
            Console.WriteLine(n);
        }

        public static string ChooseMonth(Month now)
        {
            string result = "";

            switch (now)
            {
                case Month.January:
                    result = "一月份";
                    break;
                case Month.February:
                    result = "二月份";
                    break;
                case Month.March:
                    result = "三月份";
                    break;
                case Month.April:
                    result = "四月份";
                    break;
                case Month.May:
                    result = "五月份";
                    break;
                case Month.June:
                    result = "六月份";
                    break;
                case Month.July:
                    result = "七月份";
                    break;
                case Month.August:
                    result = "八月份";
                    break;
                case Month.September:
                    result = "九月份";
                    break;
                case Month.October:
                    result = "十月份";
                    break;
                case Month.November:
                    result = "十一月份";
                    break;
                case Month.December:
                    result = "十二月份";
                    break;
                default:
                    result = "Error！";
                    break;
            }
            return result;
        }
    }
}
