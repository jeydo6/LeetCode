using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _315
	{
		public static IList<int> CountSmaller(int[] nums)
		{
			var result = new List<int>();

			var offset = 10000;
			var tree = new int[2 * 10000 + 2];

			for (var i = nums.Length - 1; i >= 0; i--)
			{
				var count = Get(nums[i] + offset, tree);
				result.Add(count);

				Update(nums[i] + offset, 1, tree);
			}


			result.Reverse();
			return result;
		}

		private static void Update(int index, int value, int[] tree)
		{
			index++;
			while (index < tree.Length)
			{
				tree[index] += value;
				index += index & -index;
			}
		}

		private static int Get(int index, int[] tree)
		{
			var result = 0;
			while (index >= 1)
			{
				result += tree[index];
				index -= index & -index;
			}
			return result;
		}
	}
}
