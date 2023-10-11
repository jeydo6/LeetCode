namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _991
	{
		public static int BrokenCalc(int startValue, int target)
		{
			var result = 0;
			while (target > startValue)
			{
				if (target % 2 == 1)
				{
					target++;
				}
				else
				{
					target /= 2;
				}
				result++;
			}
			return result + startValue - target;
		}
	}
}
