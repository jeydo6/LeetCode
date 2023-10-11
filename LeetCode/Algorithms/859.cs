namespace LeetCode.Algorithms;

// EASY
internal class _859
{
	public static bool BuddyStrings(string s, string goal)
	{
		if (s.Length != goal.Length)
		{
			return false;
		}

		if (s == goal)
		{
			var frequency = new int[26];
			for (var i = 0; i < s.Length; i++)
			{
				frequency[s[i] - 'a']++;
				if (frequency[s[i] - 'a'] == 2)
				{
					return true;
				}
			}

			return false;
		}

		var firstIndex = -1;
		var secondIndex = -1;

		for (var i = 0; i < s.Length; i++)
		{
			if (s[i] != goal[i])
			{
				if (firstIndex == -1)
				{
					firstIndex = i;
				}
				else if (secondIndex == -1)
				{
					secondIndex = i;
				}
				else
				{
					return false;
				}
			}
		}

		if (secondIndex == -1)
		{
			return false;
		}

		return s[firstIndex] == goal[secondIndex] &&
		       s[secondIndex] == goal[firstIndex];
	}
}