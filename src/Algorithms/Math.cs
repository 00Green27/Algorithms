namespace Algorithms;

public static class Math
{
	public static int Gsd(int a, int b)
	{
		while (b != 0)
		{
			(a, b) = (b, a % b);
		}

		return a;
	}
}
