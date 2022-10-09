namespace Algorithms.DataStructures;

using Xunit;

public class StackTests
{
	[Fact]
	public void StackTest()
	{
		var list = new Stack<int>();

		list.Push(5);
		list.Push(7);
		list.Push(9);

		Assert.Equal(9, list.Pop());
		Assert.Equal(2, list.Length);

		list.Push(11);
		Assert.Equal(11, list.Pop());
		Assert.Equal(7, list.Pop());
		Assert.Equal(5, list.Peek());
		Assert.Equal(5, list.Pop());

		var exception = Assert.Throws<InvalidOperationException>(() => list.Pop());
		Assert.Equal("Stack is empty", exception.Message);

		list.Push(69);
		Assert.Equal(69, list.Peek());
		Assert.Equal(1, list.Length);
	}
}
