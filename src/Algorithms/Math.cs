using System;

namespace Algorithms
{
  public static class Math
  {
    public static int Gsd(int a, int b)
    {
      int x = a, y = b, remainder = 0;
      while (y != 0)
      {
        remainder = x % y;
        x = y;
        y = remainder;
      }

      return x;
    }
  }
}
