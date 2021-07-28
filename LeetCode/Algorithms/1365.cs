namespace LeetCode.Algorithms
{
	class _1365
	{
		public static int[] SmallerNumbersThanCurrent(int[] numbers)
		{
			var result = new int[numbers.Length];
			for (var i = 0; i < numbers.Length; i++)
			{
				for (var j = 0; j < numbers.Length; j++)
				{
					if (numbers[i] > numbers[j])
					{
						result[i]++;
					}
				}
			}
			return result;
		}
	}
}
