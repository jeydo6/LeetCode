namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _371
	{
		public static int GetSum(int a, int b)
		{
			while (b != 0)
			{
				var answer = a ^ b;
				var carry = (a & b) << 1;
				a = answer;
				b = carry;
			}
			return a;
		}
	}
}
