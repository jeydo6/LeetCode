using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1874
	{
		public static int MinProductSum(int[] nums1, int[] nums2)
		{
			var counter1 = new int[101];
			for (var i = 0; i < nums1.Length; i++)
			{
				counter1[nums1[i]]++;
			}

			var counter2 = new int[101];
			for (var i = 0; i < nums2.Length; i++)
			{
				counter2[nums2[i]]++;
			}

			var result = 0;
			var lo = 0;
			var hi = 100;
			while (lo < 101 && hi > 0)
			{
				while (lo < 101 && counter1[lo] == 0)
				{
					lo += 1;
				}

				while (hi > 0 && counter2[hi] == 0)
				{
					hi -= 1;
				}

				if (lo == 101 || hi == 0)
				{
					break;
				}

				var count = Math.Min(counter1[lo], counter2[hi]);
				result += count * lo * hi;
				counter1[lo] -= count;
				counter2[hi] -= count;
			}
			return result;
		}
	}
}
