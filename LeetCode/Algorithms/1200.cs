using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	internal class _1200
	{
		public static IList<IList<int>> MinimumAbsDifference(int[] arr)
		{
			Array.Sort(arr);
			var min = int.MaxValue;
			var result = new List<IList<int>>();
			for (var i = 0; i < arr.Length - 1; i++)
			{
				var diff = arr[i + 1] - arr[i];
				if (diff < min)
				{
					min = diff;
					result.Clear();
					result.Add(new List<int> { arr[i], arr[i + 1] });
				}
				else if (diff == min)
				{
					result.Add(new List<int> { arr[i], arr[i + 1] });
				}
			}
			return result;
		}
	}
}
