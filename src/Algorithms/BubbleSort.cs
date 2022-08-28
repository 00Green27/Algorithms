using System.Collections;

namespace Algorithms;

public static class BubbleSort
{
	public static void Sort(int[] array)
	{
		var isSorted = false;
		var counter = 1;
		while (!isSorted)
		{
			isSorted = true;
			for (var i = 0; i < array.Length - counter; i++)
			{
				if (array[i] > array[i + 1])
				{
					(array[i], array[i + 1]) = (array[i + 1], array[i]);
					isSorted = false;
				}
			}
			counter++;
		}
	}
}
