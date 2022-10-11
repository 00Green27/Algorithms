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

			if (currentIndex != smallestIndex)
			{
				(array[currentIndex], array[smallestIndex]) = (array[smallestIndex], array[currentIndex]);
			}

			currentIndex++;
		}
	}

	public static void QuickSort(int[] array)
	{
		void Sort(int lo, int hi)
		{
			if (lo >= hi)
			{
				return;
			}

			var pivotIdx = Pivot(lo, hi);

			Sort(lo, pivotIdx - 1);
			Sort(pivotIdx + 1, hi);
		}

		int Pivot(int lo, int hi)
		{
			var pivot = array[hi];
			var idx = lo - 1;

			for (var i = lo; i < hi; i++)
			{
				if (array[i] <= pivot)
				{
					idx++;
					(array[i], array[idx]) = (array[idx], array[i]);
				}
			}

			idx++;
			array[hi] = array[idx];
			array[idx] = pivot;

			return idx;
		}

		Sort(0, array.Length - 1);
	}
}
