using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _421
	{
		public static int FindMaximumXOR(int[] nums)
		{
			var max = 0;
			var mask = 0;
			for (var i = 31; i >= 0; i--)
			{
				mask |= 1 << i;
				var hashSet = new HashSet<int>();
				for (var j = 0; j < nums.Length; j++)
				{
					hashSet.Add(nums[j] & mask);
				}
				var temp = max | (1 << i);
				foreach (var item in hashSet)
				{
					if (hashSet.Contains(temp ^ item))
					{
						max = temp;
						break;
					}
				}
			}
			return max;
		}
	}
}
