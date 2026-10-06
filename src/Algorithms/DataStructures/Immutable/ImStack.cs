using System.Collections;

namespace Algorithms.DataStructures.Immutable;

public interface IImStack<out T> : IEnumerable<T>
{
	T Peek();
	IImStack<T> Pop();
	bool IsEmpty { get; }
}

public class ImStack<T> : IImStack<T>
{
	private class EmptyStack : IImStack<T>
	{
		public EmptyStack() { }
		public T Peek() => throw new InvalidCastException();
		public IImStack<T> Pop() => throw new InvalidCastException();
		public bool IsEmpty => true;
		public IEnumerator<T> GetEnumerator()
		{
			yield break;
		}
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}

	public static IImStack<T> Empty { get; } = new EmptyStack();
	private readonly T item;
	private readonly IImStack<T> tail;
	private ImStack(T item, IImStack<T> tail)
	{
		this.item = item;
		this.tail = tail;
	}
	public static IImStack<T> Push(T item, IImStack<T> tail) => new ImStack<T>(item, tail);
	public T Peek() => item;
	public IImStack<T> Pop() => tail;
	public bool IsEmpty => false;


	public IEnumerator<T> GetEnumerator()
	{
		for (IImStack<T> s = this; !s.IsEmpty; s = s.Pop())
			yield return s.Peek();
	}

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public static class ImStackExtensions
{
	public static IImStack<T> Push<T>(this IImStack<T> stack, T item) =>
		ImStack<T>.Push(item, stack);
}
