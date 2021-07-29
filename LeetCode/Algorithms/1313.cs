using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _1313
	{
		public int[] DecompressRLElist(int[] numbers)
		{
			var result = new List<int>();
			for (var i = 0; i < numbers.Length / 2; i++)
			{
				for (var j = 0; j < numbers[2 * i]; j++)
				{
					result.Add(numbers[2 * i + 1]);
				}
			}
			return result.ToArray();
		}
	}
}
