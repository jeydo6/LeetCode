namespace LeetCode.Algorithms
{
	class _1588
	{
		public static int SumOddLengthSubarrays(int[] arr)
		{
			var result = 0;
			for (var i = 0; i < arr.Length; i++)
			{
				var temp = 0;
				for (var j = i; j < arr.Length; j++)
				{
					temp += arr[j];
					if ((j - i + 1) % 2 == 1)
					{
						result += temp;
					}
				}
			}
			return result;
		}
	}
}
