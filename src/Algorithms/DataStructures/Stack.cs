namespace Algorithms.DataStructures;

public class Stack<T>
{
	private Node<T> _head;

	public int Length { get; private set; }

	public void Push(T item)
	{
		var node = new Node<T> { Value = item };

		Length++;

		if (_head == null)
		{
			_head = node;
			return;
		}

		node.Prev = _head;
		_head = node;
	}

	public T Pop()
	{
		Length = System.Math.Max(0, Length - 1);

		var head = _head;
		if (Length == 0)
		{
			if (_head == null)
			{
				throw new InvalidOperationException("Stack is empty");
			}

			_head = null;

			return head.Value;
		}

		_head = head.Prev;
		head.Prev = null;

		return head.Value;
	}

	public T Peek()
	{
		if (_head == null)
		{
			throw new InvalidOperationException("Stack is empty");
		}

		return _head.Value;
	}

	private class Node<T1>
	{
		public T1 Value { get; set; }
		public Node<T1> Prev { get; set; }
	}
}
