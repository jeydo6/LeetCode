namespace LeetCode.Algorithms
{
	internal class _1137
	{
		public static int Tribonacci(int n)
		{
			var arr = new int[] { 0, 1, 1 };
			for (var i = 3; i <= n; ++i)
			{
				arr[i % 3] = arr[0] + arr[1] + arr[2];
			}
			return arr[n % 3];
		}
	}
}
