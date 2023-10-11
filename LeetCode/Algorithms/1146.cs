using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1146
{
	public class SnapshotArray
	{
		private readonly IDictionary<int, int>[] _array;

		private int _snapshotId = 0;

		public SnapshotArray(int length)
		{
			_array = new Dictionary<int, int>[length];
			for (var i = 0; i < length; i++)
			{
				_array[i] = new Dictionary<int, int> { [0] = 0 };
			}
		}

		public void Set(int index, int val)
		{
			_array[index][_snapshotId] = val;
		}

		public int Snap()
		{
			return _snapshotId++;
		}

		public int Get(int index, int snapshotId)
		{
			var dictionary = _array[index];
			while (!dictionary.ContainsKey(snapshotId))
			{
				--snapshotId;
			}

			return dictionary[snapshotId];
		}
	}
}
