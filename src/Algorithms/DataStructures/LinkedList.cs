namespace Algorithms.DataStructures;

public class LinkedList<TItem>
{
	private Node<TItem> _head;
	private Node<TItem> _tail;

	public int Length { get; private set; }

	public void Prepend(TItem item)
	{
		var node = new Node<TItem> { Value = item };

		Length++;
		if (_head == null)
		{
			_head = _tail = node;
			return;
		}

		node.Next = _head;
		_head.Prev = node;
		_head = node;
	}

	public void InsertAt(TItem item, int idx)
	{
		if (idx > Length)
		{
			throw new ArgumentOutOfRangeException(nameof(idx), "Index out of range");
		}

		if (idx == Length)
		{
			Append(item);
		}
		else if (idx == 0)
		{
			Prepend(item);
		}

		Length++;

		var curr = GetAt(idx);
		var node = new Node<TItem> { Value = item };

		node.Next = curr;
		node.Prev = curr.Prev;
		curr.Prev = node;

		if (node.Prev != null)
		{
			node.Prev.Next = node;
		}
	}

	public void Append(TItem item)
	{
		var node = new Node<TItem> { Value = item };

		Length++;
		if (_tail == null)
		{
			_head = _tail = node;
			return;
		}

		node.Prev = _tail;
		_tail.Next = node;

		_tail = node;
	}

	public bool Remove(TItem item)
	{
		var curr = _head;

		for (var i = 0; curr != null && i < Length; i++)
		{
			if (curr.Value.Equals(item))
			{
				break;
			}
			curr = curr.Next;
		}

		if (curr == null)
		{
			return false;
		}

		return RemoveNode(curr);
	}

	public TItem Get(int idx)
	{
		var node = GetAt(idx);
		return node != null ? node.Value : throw new ArgumentOutOfRangeException(nameof(idx), "Index out of range");
	}

	public bool RemoveAt(int idx)
	{
		var node = GetAt(idx);

		if (node == null)
		{
			return false;
		}

		return RemoveNode(node);
	}

	private bool RemoveNode(Node<TItem> node)
	{
		Length--;
		if (Length == 0)
		{
			var result = _head != null;
			_head = _tail = null;
			return result;
		}

		if (node.Prev != null)
		{
			node.Prev.Next = node.Next;
		}

		if (node.Next != null)
		{
			node.Next.Prev = node.Prev;
		}

		if (node == _head)
		{
			_head = node.Next;
		}

		if (node == _tail)
		{
			_tail = node.Prev;
		}

		node.Prev = node.Next = null;

		return true;
	}

	private Node<TItem> GetAt(int idx)
	{
		var curr = _head;
		for (var i = 0; curr != null && i < idx; i++)
		{
			curr = curr.Next;
		}

		return curr;
	}

	class Node<T>
	{
		public Node<T> Prev { get; set; }
		public Node<T> Next { get; set; }
		public T Value { get; set; }
	}
}
