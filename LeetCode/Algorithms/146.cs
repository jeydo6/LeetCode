using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _146
	{
		public class LRUCache
		{
			public class Node
			{
				public int key;
				public int val;
				public Node prev;
				public Node next;
			}

			private readonly int _capacity;
			private readonly IDictionary<int, Node> _cache;
			private readonly Node _head;
			private readonly Node _tail;

			private int _count;
			
			public LRUCache(int capacity)
			{
				_capacity = capacity;
				_cache = new Dictionary<int, Node>();

				_head = new Node();
				_tail = new Node();
				_head.next = _tail;
				_tail.prev = _head;

				_count = 0;
			}

			public int Get(int key)
			{
				if (_cache.ContainsKey(key))
				{
					var node = _cache[key];
					MoveToFirst(node);
					return node.val;
				}
				else
				{
					return -1;
				}
			}

			public void Put(int key, int value)
			{
				if (_count < _capacity)
				{
					if (!_cache.ContainsKey(key))
					{
						var node = new Node
						{
							key = key,
							val = value
						};
						AddToFirst(node);
						_cache.Add(key, node);
						_count++;
					}
					else
					{
						var node = _cache[key];
						node.val = value;
						MoveToFirst(node);
					}
				}
				else
				{
					if (!_cache.ContainsKey(key))
					{
						var node = _tail.prev;
						_cache.Remove(node.key);

						node.key = key;
						node.val = value;
						MoveToFirst(node);
						_cache.Add(key, node);
					}
					else
					{
						var node = _cache[key];
						node.val = value;
						MoveToFirst(node);
					}

				}

			}

			private void MoveToFirst(Node node)
			{
				node.prev.next = node.next;
				node.next.prev = node.prev;
				AddToFirst(node);
			}

			private void AddToFirst(Node node)
			{
				node.next = _head.next;
				node.prev = _head;
				_head.next = node;
				node.next.prev = node;
			}
		}
	}
}
