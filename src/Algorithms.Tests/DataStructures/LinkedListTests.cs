namespace Algorithms.DataStructures;

using Xunit;

public class LinkedListTests
{
	[Fact]
	public void LinkedListTest()
	{
		var list = new LinkedList<int>();
		list.Append(5);
		list.Append(7);
		list.Append(9);

		Assert.Equal(9, list.Get(2));
		Assert.True(list.RemoveAt(1));
		Assert.Equal(2, list.Length);

		list.Append(11);
		Assert.True(list.RemoveAt(1));
		Assert.False(list.Remove(9));
		Assert.True(list.RemoveAt(0));
		Assert.True(list.RemoveAt(0));
		Assert.Equal(0, list.Length);

		list.Prepend(5);
		list.Prepend(7);
		list.Prepend(9);

		Assert.Equal(5, list.Get(2));
		Assert.Equal(9, list.Get(0));
		Assert.True(list.Remove(9));
		Assert.Equal(2, list.Length);
		Assert.Equal(7, list.Get(0));
	}
}
