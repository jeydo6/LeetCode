namespace LeetCode.Algorithms
{
	class _522
	{
		public static int FindLUSlength(string[] strs)
		{
			Array.Sort(strs, (str1, str2) => str2.Length - str1.Length);

			var duplicates = new Dictionary<string, int>();
			foreach (string str in strs)
			{
				if (duplicates.ContainsKey(str))
				{
					duplicates[str]++;
				}
				else
				{
					duplicates[str] = 1;
				}
			}

			for (var i = 0; i < strs.Length; i++)
			{
				if (duplicates[strs[i]] == 1)
				{
					if (i == 0)
					{
						return strs[i].Length;
					}

					for (var j = 0; j < i; j++)
					{
						if (IsSubsequence(strs[j], strs[i]))
						{
							break;
						}
						if (j == i - 1)
						{
							return strs[i].Length;
						}
					}
				}
			}

			return -1;
		}

		private static bool IsSubsequence(string str1, string str2)
		{
			var i = 0;
			var j = 0;
			while (i < str1.Length && j < str2.Length)
			{
				if (str1[i] == str2[j])
				{
					j++;
				}
				i++;
			}
			return j == str2.Length;
		}
	}
}
