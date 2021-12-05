
using Xunit;

namespace Algorithms;
public class SearchTests
{
	[Theory]
	[InlineData(1, 1, 5, 0)]
	[InlineData(5, 1, 5, 4)]
	[InlineData(4, 1, 10, 3)]
	[InlineData(41, 1, 100, 40)]
	[InlineData(2, 1, 2, 1)]
	[InlineData(-999, 1, 100, null)]
	[InlineData(999, 1, 100, null)]
	public void BinarySearch(int item, int min, int max, int? result)
	{
		var found = Search.BinarySearch(item, Enumerable.Range(min, max).ToArray());
		Assert.Equal(found, result);
	}
}
