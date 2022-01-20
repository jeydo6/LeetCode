namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _875
	{
		public static int MinEatingSpeed(int[] piles, int h)
		{
			var l = 1;
			var r = 1000000000;
			while (l < r)
			{
				var m = (l + r) / 2;
				var total = 0;
				for (var i = 0; i < piles.Length; i++)
				{
					total += (piles[i] + m - 1) / m;
				}

				if (total > h)
				{
					l = m + 1;
				}
				else
				{
					r = m;
				}
			}
			return l;
		}
	}
}
