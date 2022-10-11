
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
	[InlineData(new[] { 9, 3, 7, 4, 69, 420, 42 }, new[] { 3, 4, 7, 9, 42, 69, 420 })]
	public void BubbleSort(int[] array, int[] result)
	{
		Sort.BubbleSort(array);
		array.Should().Equal(result);
	}

	[Theory]
	[InlineData(new[] { 0 }, new[] { 0 })]
	[InlineData(new[] { 2, 1 }, new[] { 1, 2 })]
	[InlineData(new[] { -2, 0, 1 }, new[] { -2, 0, 1 })]
	[InlineData(new[] { 5, 3, 8, 2, 9, 5 }, new[] { 2, 3, 5, 5, 8, 9 })]
	[InlineData(new[] { 9, 3, 7, 4, 69, 420, 42 }, new[] { 3, 4, 7, 9, 42, 69, 420 })]
	public void InsertionSort(int[] array, int[] result)
	{
		Sort.InsertionSort(array);
		array.Should().Equal(result);
	}

	[Theory]
	[InlineData(new[] { 0 }, new[] { 0 })]
	[InlineData(new[] { 2, 1 }, new[] { 1, 2 })]
	[InlineData(new[] { -2, 0, 1 }, new[] { -2, 0, 1 })]
	[InlineData(new[] { 5, 3, 8, 2, 9, 5 }, new[] { 2, 3, 5, 5, 8, 9 })]
	[InlineData(new[] { 9, 3, 7, 4, 69, 420, 42 }, new[] { 3, 4, 7, 9, 42, 69, 420 })]
	public void SelectionSort(int[] array, int[] result)
	{
		Sort.SelectionSort(array);
		array.Should().Equal(result);
	}

	[Theory]
	[InlineData(new[] { 0 }, new[] { 0 })]
	[InlineData(new[] { 2, 1 }, new[] { 1, 2 })]
	[InlineData(new[] { -2, 0, 1 }, new[] { -2, 0, 1 })]
	[InlineData(new[] { 5, 3, 8, 2, 9, 5 }, new[] { 2, 3, 5, 5, 8, 9 })]
	[InlineData(new[] { 9, 3, 7, 4, 69, 420, 42 }, new[] { 3, 4, 7, 9, 42, 69, 420 })]
	public void QuickSort(int[] array, int[] result)
	{
		Sort.QuickSort(array);
		array.Should().Equal(result);
	}
}
