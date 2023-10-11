namespace Leetcode.Algorithms
{
	internal class _771
	{
		public static int NumJewelsInStones(string jewels, string stones)
		{
			int result = 0;
			foreach (var s in stones)
			{
				if (jewels.Contains(s))
				{
					result++;
				}
			}
			return result;
		}
	}
}
