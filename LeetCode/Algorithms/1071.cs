namespace LeetCode.Algorithms;

// EASY
internal class _1071
{
	public static string GcdOfStrings(string str1, string str2)
	{
		if (str1 + str2 != str2 + str1)
		{
			return "";
		}

		return str1[..GcdOfInts(str1.Length, str2.Length)];
	}

	private static int GcdOfInts(int val1, int val2)
	{
		while (val1 > 0 && val2 > 0)
		{
			if (val1 > val2)
			{
				val1 %= val2;
			}
			else
			{
				val2 %= val1;
			}
		}

		return val1 | val2;
	}
}
