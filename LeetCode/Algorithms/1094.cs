namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1094
	{
		public static bool CarPooling(int[][] trips, int capacity)
		{
			var stops = new int[1001];
			for (var i = 0; i < trips.Length; i++)
			{
				stops[trips[i][1]] += trips[i][0];
				stops[trips[i][2]] -= trips[i][0];
			}
			for (var i = 0; capacity >= 0 && i < 1001; i++)
			{
				capacity -= stops[i];
			}
			return capacity >= 0;
		}
	}
}
