using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _923
	{
		public static int ThreeSumMulti(int[] arr, int target)
		{
			var modulo = 1_000_000_007;
			var result = 0L;
			Array.Sort(arr);
			for (var i = 0; i < arr.Length; ++i)
			{
				var t = target - arr[i];

				var lo = i + 1;
				var hi = arr.Length - 1;
				while (lo < hi)
				{
					if (arr[lo] + arr[hi] < t)
					{
						lo++;
					}
					else if (arr[lo] + arr[hi] > t)
					{
						hi--;
					}
					else if (arr[lo] != arr[hi])
					{
						var left = 1;
						var right = 1;
						while (lo + 1 < hi && arr[lo] == arr[lo + 1])
						{
							left++;
							lo++;
						}
						while (hi - 1 > lo && arr[hi] == arr[hi - 1])
						{
							right++;
							hi--;
						}

						result += left * right;
						result %= modulo;
						lo++;
						hi--;
					}
					else
					{
						result += (hi - lo + 1) * (hi - lo) / 2;
						result %= modulo;
						break;
					}
				}
			}

			return (int)result;
		}
	}
}
