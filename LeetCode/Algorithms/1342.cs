namespace LeetCode.Algorithms
{
	class _1342
	{
		public static int NumberOfSteps(int number)
		{
			var result = 0;
			while (number > 0)
			{
				if (number % 2 == 0)
				{
					number /= 2;
				}
				else
				{
					number -= 1;
				}
				result++;
			}
			return result;
		}
	}
}
