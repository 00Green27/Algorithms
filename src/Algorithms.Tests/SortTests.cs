
using FluentAssertions;
using Xunit;

namespace Algorithms;
public class SortTests
{
	[Theory]
	[InlineData(new[] { 0 }, new[] { 0 })]
	[InlineData(new[] { 2, 1 }, new[] { 1, 2 })]
	[InlineData(new[] { -2, 0, 1 }, new[] { -2, 0, 1 })]
	[InlineData(new[] { 5, 3, 8, 2, 9, 5 }, new[] { 2, 3, 5, 5, 8, 9 })]
	public void BubbleSort(int[] array, int[] result)
	{
		Algorithms.BubbleSort.Sort(array);
		array.Should().Equal(result);
	}
}