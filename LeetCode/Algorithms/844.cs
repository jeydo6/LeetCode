namespace LeetCode.Algorithms;

// EASY
internal class _844
{
	public static bool BackspaceCompare(string s, string t)
	{
		var skipS = 0;
		var skipT = 0;

		var i = s.Length - 1;
		var j = t.Length - 1;
		while (i >= 0 || j >= 0)
		{
			while (i >= 0)
			{
				if (s[i] == '#')
				{
					skipS++;
					i--;
				}
				else if (skipS > 0)
				{
					skipS--;
					i--;
				}
				else
				{
					break;
				}
			}

			while (j >= 0)
			{
				if (t[j] == '#')
				{
					skipT++;
					j--;
				}
				else if (skipT > 0)
				{
					skipT--;
					j--;
				}
				else
				{
					break;
				}
			}

			if (i >= 0 && j >= 0 && s[i] != t[j])
			{
				return false;
			}

			if ((i >= 0) != (j >= 0))
			{
				return false;
			}

			i--;
			j--;
		}
		return true;
	}
}
