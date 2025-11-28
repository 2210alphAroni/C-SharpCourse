using System;

namespace MyApplication
{
  class Multiple_Variables
  {
    static void Main(string[] args)
    {
      int x = 5, y = 6, z = 50;
      Console.WriteLine(x + y + z);

      int p, q, r;
      p = q = r = 50;
      Console.WriteLine(p + q + r);
    }
  }
}