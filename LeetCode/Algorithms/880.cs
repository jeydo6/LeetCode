namespace LeetCode.Algorithms;

internal class _880
{
	public static string DecodeAtIndex(string s, long k)
	{
		int i;
		var n = 0L;
		for (i = 0; n < k; i++)
		{
			n = char.IsDigit(s[i]) ? n * (s[i] - '0') : n + 1;
		}

		for (i--; i > 0; i--)
		{
			if (char.IsDigit(s[i]))
			{
				n /= s[i] - '0';
				k %= n;
			}
			else
			{
				if (k % n == 0)
				{
					break;
				}
				n--;
			}
		}

		return s[i].ToString();
	}
}