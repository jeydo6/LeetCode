using System.Linq;

namespace LeetCode.Algorithms
{
	class _1920
	{
		public static int[] BuildArray(int[] numbers)
		{
			return numbers
				.Where(i => i >= 0 && i < numbers.Length)
				.Select(i => numbers[i])
				.ToArray();
		}
	}
}
