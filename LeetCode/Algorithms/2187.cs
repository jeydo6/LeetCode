namespace LeetCode.Algorithms;

// MEDIUM
internal class _2187
{
	public static long MinimumTime(int[] time, int totalTrips)
	{
		var start = 1L;
		var end = (long)1e14;
		while (start <= end)
		{
			var trip = 0L;
			var mid = start + (end - start) / 2;
			for (var i = 0; i < time.Length; i++)
			{
				trip += mid / time[i];
			}

			if (trip < totalTrips)
			{
				start = mid + 1;
			}
			else
			{
				end = mid - 1;
			}
		}
		return start;
	}
}
