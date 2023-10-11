using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _706
{
	public class MyHashMap
	{
		private class Bucket
		{
			private class Pair
			{
				public Pair(int key, int value)
				{
					Key = key;
					Value = value;
				}

				public int Key { get; set; }

				public int Value { get; set; }
			}

			private readonly LinkedList<Pair> _container;

			public Bucket()
			{
				_container = new LinkedList<Pair>();
			}

			public void Put(int key, int value)
			{
				foreach (var pair in _container)
				{
					if (pair.Key == key)
					{
						pair.Value = value;
						return;
					}
				}

				_container.AddFirst(new Pair(key, value));
			}

			public int Get(int key)
			{
				foreach (var pair in _container)
				{
					if (pair.Key == key)
					{
						return pair.Value;
					}
				}
				return -1;
			}

			public void Remove(int key)
			{
				foreach (var pair in _container)
				{
					if (pair.Key == key)
					{
						_container.Remove(pair);
						return;
					}
				}
			}
		}

		private readonly Bucket[] _buckets;

		public MyHashMap()
		{
			_buckets = new Bucket[2069];
			for (var i = 0; i < _buckets.Length; i++)
			{
				_buckets[i] = new Bucket();
			}
		}

		public void Put(int key, int value)
		{
			var index = GetHash(key);
			_buckets[index].Put(key, value);
		}

		public int Get(int key)
		{
			var index = GetHash(key);
			return _buckets[index].Get(key);
		}

		public void Remove(int key)
		{
			var index = GetHash(key);
			_buckets[index].Remove(key);
		}

		private int GetHash(int key)
		{
			return key % _buckets.Length;
		}
	}
}
