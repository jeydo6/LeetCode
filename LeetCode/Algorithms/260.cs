namespace LeetCode.Algorithms
{
	//EASY
	internal class _260
	{
		public static int[] SingleNumber(int[] nums)
		{
			var diff = 0;
			foreach (var num in nums)
			{
				diff ^= num;
			}
			diff &= -diff;

			var result = new[] { 0, 0 };
			foreach (var num in nums)
			{
				if ((num & diff) == 0)
				{
					result[0] ^= num;
				}
				else
				{
					result[1] ^= num;
				}
			}
			return result;
		}
	}
}
