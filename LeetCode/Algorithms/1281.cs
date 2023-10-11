namespace LeetCode.Algorithms
{
	class _1281
	{
		public static int SubtractProductAndSum(int n)
		{
			var sum = 0;
			var product = 1;
			foreach (var ch in n.ToString())
			{
				var value = ch - '0';
				sum += value;
				product *= value;
			}
			return product - sum;
		}
	}
}
