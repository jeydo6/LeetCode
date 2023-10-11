using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _705
	{
		public class MyHashSet
		{
			private class Bucket
			{
				private readonly LinkedList<int> _container;

				public Bucket()
				{
					_container = new LinkedList<int>();
				}

				public void Add(int key)
				{
					if (!_container.Contains(key))
					{
						_container.AddFirst(key);
					}
				}

				public void Remove(int key)
				{
					_container.Remove(key);
				}

				public bool Contains(int key)
				{
					return _container.Contains(key);
				}
			}

			private readonly Bucket[] _buckets;

			public MyHashSet()
			{
				_buckets = new Bucket[769];
				for (var i = 0; i < _buckets.Length; i++)
				{
					_buckets[i] = new Bucket();
				}
			}

			public void Add(int key)
			{
				var index = GetHash(key);
				_buckets[index].Add(key);
			}

			public void Remove(int key)
			{
				var index = GetHash(key);
				_buckets[index].Remove(key);
			}

			public bool Contains(int key)
			{
				var index = GetHash(key);
				return _buckets[index].Contains(key);
			}

			private int GetHash(int key)
			{
				return key % _buckets.Length;
			}
		}
	}
}
