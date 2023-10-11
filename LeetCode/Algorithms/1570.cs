using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1570
	{
		public class SparseVector
		{
			private readonly IDictionary<int, int> _nums;

			public SparseVector(int[] nums)
			{
				_nums = new Dictionary<int, int>();
				for (var i = 0; i < nums.Length; i++)
				{
					if (nums[i] != 0)
					{
						_nums[i] = nums[i];
					}
				}
			}

			public int DotProduct(SparseVector vec)
			{
				var result = 0;
				foreach (var i in vec._nums.Keys)
				{
					if (_nums.ContainsKey(i))
					{
						result += _nums[i] * vec._nums[i];
					}
				}
				return result;
			}
		}
	}
}
