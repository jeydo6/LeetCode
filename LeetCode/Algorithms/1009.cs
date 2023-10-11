namespace LeetCode.Algorithms
{
	// EASY
	internal class _1009
	{
		public static int BitwiseComplement(int n)
		{
			var x = 1;
			while (n > x)
			{
				x = x * 2 + 1;
			}
			return x - n;
		}
	}
}
