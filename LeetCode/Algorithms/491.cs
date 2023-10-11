using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _491
{
	public static IList<IList<int>> FindSubsequences(int[] nums)
	{
		var result = new HashSet<IList<int>>(new EqualityComparer());
		for (var bitmask = 1; bitmask < (1 << nums.Length); bitmask++)
		{
			var sequence = new List<int>();
			for (var i = 0; i < nums.Length; i++)
			{
				if (((bitmask >> i) & 1) == 1)
				{
					sequence.Add(nums[i]);
				}
			}

			if (sequence.Count >= 2)
			{
				var isIncreasing = true;
				for (var i = 0; i < sequence.Count - 1; i++)
				{
					isIncreasing &= sequence[i] <= sequence[i + 1];
				}

				if (isIncreasing)
				{
					result.Add(sequence);
				}
			}
		}
		return new List<IList<int>>(result);
	}

	private class EqualityComparer : IEqualityComparer<IList<int>>
	{
		public bool Equals(IList<int> list1, IList<int> list2)
		{
			if (list1 == null && list2 == null)
			{
				return true;
			}
			else if (list1 == null || list2 == null)
			{
				return false;
			}
			else if (list1 == list2)
			{
				return true;
			}
			else if (list1.Count != list2.Count)
			{
				return false;
			}
			else
			{
				var length = list1.Count;
				for (var i = 0; i < length; i++)
				{
					if (list1[i] != list2[i])
					{
						return false;
					}
				}
			}

			return true;
		}

		public int GetHashCode(IList<int> list)
		{
			var result = list.Count;
			foreach (var item in list)
			{
				result = HashCode.Combine(result, item);
			}

			return result;
		}
	}
}
