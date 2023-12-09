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

	public static bool IsPrime(int n)
	{
		if (n < 2) return false;

		var sieve = Eratosthenes(n);
		return sieve[n];
	}

	private static bool[] Eratosthenes(int n)
	{
		bool[] numbers = new bool[n + 1];
		Array.Fill(numbers, true);
		numbers[0] = numbers[1] = false;

		for (int i = 2; i < n; i++)
		{
			if (numbers[i])
			{
				for (int j = i * i; j <= n; j += i)
				{
					numbers[j] = false;
				}
			}
		}

		return numbers;
	}
}
