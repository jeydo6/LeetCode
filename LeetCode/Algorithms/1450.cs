namespace LeetCode.Algorithms
{
	class _1450
	{
		public static int BusyStudent(int[] startTime, int[] endTime, int queryTime)
		{
			var result = 0;
			for (var i = 0; i < startTime.Length; i++)
			{
				if (queryTime >= startTime[i] && queryTime <= endTime[i])
				{
					result++;
				}
			}
			return result;
		}
	}
}
