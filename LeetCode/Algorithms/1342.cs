namespace LeetCode.Algorithms
{
	// EASY
	internal class _1342
	{
		public static int NumberOfSteps(int num)
		{
			var result = 0;
			while (num > 0)
			{
				if (num % 2 == 0)
				{
					num /= 2;
				}
				else
				{
					num -= 1;
				}
				result++;
			}
			return result;
		}
	}
}
