using System;

namespace Algorithms
{
  public static class Math
  {
    public static int Gsd(int a, int b)
    {
      int x = a, y = b;
      while (y != 0)
      {
        int remainder = x % y;
        x = y;
        y = remainder;
      }

      return x;
    }
  }
}
