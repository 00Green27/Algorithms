namespace Algorithms.DataStructures.Immutable;

public sealed record LinkedList<T>(T? Value, LinkedList<T>? Tail)
{
	public static LinkedList<T> Empty = new(default, null);
	public LinkedList<T> Push(T value) => new(value, this);
	// public bool IsEmpty => this == Empty;
	public bool IsEmpty => Tail == null;

	public LinkedList<T> Reverse()
	{
		var result = Empty;
		for (var list = this; !list.IsEmpty; list = list.Tail!)
			result = result.Push(list.Value!);
		return result;
	}

	public override string ToString()
	{
		var sb = new StringBuilder();
		for (var list = this; !list.IsEmpty; list = list.Tail!)
			sb.Append(list.Value).Append(' ');

		return sb.ToString();
	}
}
