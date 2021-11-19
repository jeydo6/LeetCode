namespace LeetCode.Algorithms
{
	public class _461
	{
		public static int HammingDistance(int x, int y)
		{
			var result = 0;
			var xor = x ^ y;
			while (xor != 0)
			{
				result += xor & 1;
				xor >>= 1;
			}
			return result;
		}
	}
}
