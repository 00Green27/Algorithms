namespace Algorithms.DataStructures;

public class Queue<T>
{
	private Node<T> _head;
	private Node<T> _tail;
	public int Length { get; private set; }

	public void Enqueue(T item)
	{
		var node = new Node<T>
		{
			Value = item
		};

		Length++;

		if (_tail == null)
		{
			_tail = _head = node;
			return;
		}

		_tail.Next = node;
		_tail = node;
	}

	public T Dequeue()
	{
		if (_head == null)
		{
			throw new InvalidOperationException("Queue is empty");
		}

		Length--;
		var head = _head;
		_head = _head.Next;

		if (_head == null)
		{
			_tail = null;
		}

		head.Next = null;

		return head.Value;
	}

	public T Peek()
	{
		if (_head == null)
		{
			throw new InvalidOperationException("Queue is empty");
		}

		return _head.Value;
	}
}
