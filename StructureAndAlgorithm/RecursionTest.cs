using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructureAndAlgorithm
{
  class RecursionTest
  {
    static void Main(string[] arg)
    {
      WriteLine($"5! = {Fac(5)}"); //$ 引用符，""内为字符串，{}内为执行
    }

    static int Fac(int n)
    {
      if (n == 0) //递归终止条件
      {
        return 1;
      }
      else
      {
        return n * Fac(n - 1); //递归调用
      }
    }
  }
}