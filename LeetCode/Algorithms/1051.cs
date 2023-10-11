namespace Leetcode.Algorithms
{
	internal class _1051
	{
		public static int HeightChecker(int[] heights)
		{
			var freq = new int[101];
			foreach (var height in heights)
			{
				freq[height]++;
			}

			var result = 0;
			var current = 0;
			foreach (var height in heights)
			{
				while (freq[current] == 0)
				{
					current++;
				}

				if (current != height)
				{
					result++;
				}
				freq[current]--;
			}
			return result;
		}
	}
}
