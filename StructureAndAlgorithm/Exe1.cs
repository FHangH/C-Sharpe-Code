using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructureAndAlgorithm
{
  class Exe1
  {
    static void Main(string[] args)
    {
      Test1();
    }

    static void Test1()
    {
      int n;

      WriteLine("请输入一个整数值，求出f(n)的值");
      Write("n = ");

      n = int.Parse(ReadLine());

      if (n >= 1)
      {
        n *= n;
      }
      else
      {
        n = 0;
      }
      Console.WriteLine();
      Console.WriteLine("f(n)= " + n);
    }
  }
}