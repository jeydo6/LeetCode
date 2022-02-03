using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _454
	{
		public static int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
		{
			var result = 0;
			var dict = new Dictionary<int, int>();
			for (var i = 0; i < nums3.Length; i++)
			{
				for (var j = 0; j < nums4.Length; j++)
				{
					var sum = nums3[i] + nums4[j];
					if (!dict.ContainsKey(sum))
					{
						dict[sum] = 0;
					}
					dict[sum]++;
				}
			}
			for (var i = 0; i < nums1.Length; i++)
			{
				for (var j = 0; j < nums2.Length; j++)
				{
					var sum = nums1[i] + nums2[j];
					if (dict.ContainsKey(-sum))
					{
						result += dict[-sum];
					}
				}
			}
			return result;
		}
	}
}
