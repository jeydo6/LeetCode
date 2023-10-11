using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _460
{
	public class LFUCache
	{
		private readonly IDictionary<int, (int Frequency, int Value)> _cache = new Dictionary<int, (int Frequency, int Value)>();
		private readonly IDictionary<int, IList<int>> _frequencies = new Dictionary<int, IList<int>>();

		private readonly int _capacity;

		private int _minFrequency;

		public LFUCache(int capacity)
		{
			_capacity = capacity;
		}

		public int Get(int key)
		{
			if (!_cache.ContainsKey(key))
			{
				return -1;
			}

			var (frequency, value) = _cache[key];
			var keys = _frequencies[frequency];
			keys.Remove(key);
			if (_minFrequency == frequency && keys.Count == 0)
			{
				_minFrequency++;
			}
			Insert(key, frequency + 1, value);
			return value;
		}

		public void Put(int key, int value)
		{
			if (_capacity <= 0)
			{
				return;
			}
			
			if (_cache.ContainsKey(key))
			{
				_cache[key] = (_cache[key].Frequency, value);
				Get(key);
				return;
			}

			if (_cache.Count == _capacity)
			{
				var keys = _frequencies[_minFrequency];
				foreach (var keyToDelete in keys)
				{
					_cache.Remove(keyToDelete);
					keys.Remove(keyToDelete);
					break;
				}
			}
			_minFrequency = 1;
			Insert(key, 1, value);
		}

		private void Insert(int key, int frequency, int value)
		{
			_cache[key] = (frequency, value);
			if (!_frequencies.ContainsKey(frequency))
			{
				_frequencies[frequency] = new List<int>();
			}
			_frequencies[frequency].Add(key);
		}
	}
}
