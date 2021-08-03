namespace LeetCode.Algorithms
{
	class _1295
	{
		public static int FindNumbers(int[] numbers)
		{
			var result = 0;
			foreach (var number in numbers)
			{
				var length = 0;

				var temp = number;
				while (temp > 0)
				{
					length++;
					temp /= 10;
				}

				if (length % 2 == 0)
				{
					result++;
				}
			}
			return result;
		}
	}
}
