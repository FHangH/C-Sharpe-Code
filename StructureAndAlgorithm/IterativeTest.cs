using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructureAndAlgorithm
{
  class IterativeTest
  {
    static void Main(string[] args)
    {
      int n;
      int sum = 1;

      Write("输入n = ");
      n = int.Parse(ReadLine());

      for (int i = 1; i < n + 1; i++)
      {
        for (int j = i; j > 0; j--)
        {
          sum = sum * j;
        }
        WriteLine(i + "!=" + sum);
        sum = 1;
      }
    }
  }
}