namespace LeetCode.Algorithms;

// MEDIUM
internal class _2405
{
	public static int PartitionString(string s)
	{
		var seen = new int[26];
		for (var i = 0; i < seen.Length; i++)
		{
			seen[i] = -1;
		}

		var result = 1;
		var start = 0;
		for (var i = 0; i < s.Length; i++)
		{
			if (seen[s[i] - 'a'] >= start)
			{
				result++;
				start = i;
			}
			seen[s[i] - 'a'] = i;
		}

		return result;
	}
}
