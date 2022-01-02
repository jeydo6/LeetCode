namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1010
	{
		public static int NumPairsDivisibleBy60(int[] time)
		{
			var result = 0;
			var arr = new int[60];
			for (var i = 0; i < time.Length; i++)
			{
				result += arr[(600 - time[i]) % 60];
				arr[time[i] % 60] += 1;
			}
			return result;
		}
	}
}
