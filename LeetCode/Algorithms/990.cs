namespace LeetCode.Algorithms;

// MEDIUM
internal class _990
{
	public static bool EquationsPossible(string[] equations)
	{
		var set = new int[26];
		for (var i = 0; i < 26; i++)
		{
			set[i] = i;
		}

		foreach (var equation in equations)
		{
			if (equation[1] == '=')
			{
				var item1 = equation[0] - 'a';
				var item2 = equation[3] - 'a';
				Union(set, item1, item2);
			}
		}

		foreach (var equation in equations)
		{
			if (equation[1] == '!')
			{
				var item1 = equation[0] - 'a';
				var item2 = equation[3] - 'a';
				if (Find(set, item1) == Find(set, item2))
				{
					return false;
				}
			}
		}

		return true;
	}

	private static int Find(int[] set, int item)
	{
		if (set[item] != item)
		{
			set[item] = Find(set, set[item]);
		}

		return set[item];
	}

	private static void Union(int[] set, int item1, int item2)
	{
		item1 = Find(set, item1);
		item2 = Find(set, item2);
		if (item1 != item2)
		{
			set[item1] = item2;
		}
	}
}
