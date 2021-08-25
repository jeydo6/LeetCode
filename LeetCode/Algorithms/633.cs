namespace LeetCode.Algorithms
{
	class _633
	{
		public static bool JudgeSquareSum(int c)
		{
			var a = 0;
			var b = (int)Math.Sqrt(c);
			while (a <= b)
			{
				var t = a * a + b * b;
				if (t < c)
				{
					a++;
				}
				else if (t > c)
				{
					b--;
				}
				else
				{
					return true;
				}
			}
			return false;
		}
	}
}
