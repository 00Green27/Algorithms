namespace Algorithms;

public static class Sort
{
	public static void BubbleSort(int[] array)
	{
		for (var i = 0; i < array.Length; i++)
		{
			for (var j = 0; j < array.Length - i - 1; j++)
			{
				if (array[j] > array[j + 1])
				{
					(array[j], array[j + 1]) = (array[j + 1], array[j]);
				}
			}
		}
	}

	public static void InsertionSort(int[] array)
	{
		for (var i = 1; i < array.Length; i++)
		{
			var j = i;
			while (j > 0 && array[j] < array[j - 1])
			{
				(array[j], array[j - 1]) = (array[j - 1], array[j]);
				j--;
			}
		}
	}

	public static void SelectionSort(int[] array)
	{
		var currentIndex = 0;
		while (currentIndex < array.Length - 1)
		{
			var smallestIndex = currentIndex;
			for (var i = currentIndex + 1; i < array.Length; i++)
			{
				if (array[smallestIndex] > array[i])
				{
					smallestIndex = i;
				}
			}

			(array[currentIndex], array[smallestIndex]) = (array[smallestIndex], array[currentIndex]);
			currentIndex++;
		}
	}
}
