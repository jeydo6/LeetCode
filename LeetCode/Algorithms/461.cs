namespace LeetCode.Algorithms
{
	public class _461
	{
		public static int HammingDistance(int x, int y)
		{
			var result = 0;
			while (x > 0 || y > 0)
			{
				if (x % 2 != y % 2)
				{
					result++;
				}

				x = x / 2;
				y = y / 2;
			}
			return result;
		}
	}
}
