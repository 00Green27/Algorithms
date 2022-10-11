namespace Algorithms;
public static class Search
{
	public static int? BinarySearch(int item, IList<int> values)
	{
		int low = 0;
		int hight = values.Count - 1;

		while (low <= hight)
		{
			int mid = low + ((hight - low) / 2);
			if (values[mid] == item)
			{
				return mid;
			}

			if (values[mid] < item)
			{
				low = mid + 1;
			}
			else
			{
				hight = mid - 1;
			}
		}

		return null;
	}
}
