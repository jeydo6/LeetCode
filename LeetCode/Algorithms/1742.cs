namespace LeetCode.Algorithms
{
	class _1742
	{
		public static int CountBalls(int lowLimit, int highLimit)
		{
			var dict = new Dictionary<int, int>();
			for (var i = lowLimit; i <= highLimit; i++)
			{
				var sum = 0;
				var number = i;
				while (number > 0)
				{
					sum += number % 10;
					number /= 10;
				}

				if (dict.ContainsKey(sum))
				{
					dict[sum]++;
				}
				else
				{
					dict[sum] = 1;
				}
			}

			var max = int.MinValue;
			foreach (var key in dict.Keys)
			{
				if (dict[key] > max) max = dict[key];
			}
			return max;
		}
	}
}
