namespace Algorithms;

public static class Fibonacci
{
	public static int Calculate(int N)
	{
		if (N == 0)
		{
			return 0;
		}

		if (N == 1)
		{
			return 1;
		}

		int n1 = 1, n2 = 1;
		for (int i = 2; i < N; i++)
		{
			n2 = n1 + n2;
			n1 = n2 - n1;
		}

		return n2;
	}
}
