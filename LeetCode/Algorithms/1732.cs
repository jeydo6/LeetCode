namespace LeetCode.Algorithms;

// EASY
internal class _1732
{
	public static int LargestAltitude(int[] gain)
	{
		var result = 0;
		var altitude = 0;
		foreach (var item in gain)
		{
			altitude += item;
			if (altitude > result)
			{
				result = altitude;
			}
		}

		return result;
	}
}