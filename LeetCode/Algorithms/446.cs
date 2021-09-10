namespace LeetCode.Algorithms
{
	// HARD
	class _446
	{
		public static int NumberOfArithmeticSlices(int[] nums)
		{
			var result = 0;

			var dict = new Dictionary<int, int>[nums.Length];

			for (var i = 0; i < nums.Length; i++)
			{
				dict[i] = new Dictionary<int, int>(i);
				for (var j = 0; j < i; j++)
				{
					var diff = (long)nums[i] - nums[j];
					if (diff <= int.MinValue || diff > int.MaxValue)
					{
						continue;
					}

					var key = (int)diff;
					dict[i].TryGetValue(key, out var value1);
					dict[j].TryGetValue(key, out var value2);

					result += value2;

					dict[i][key] = value1 + value2 + 1;
				}
			}

			return result;
		}
	}
}
