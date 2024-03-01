namespace LeetCode.Algorithms;

// EASY
internal sealed class _2864
{
	public static string MaximumOddBinaryNumber(string s)
	{
		var arr = s.ToCharArray();

		var lo = 0;
		var hi = arr.Length - 1;
		while (lo <= hi)
		{
			if (arr[lo] == '1')
			{
				lo++;
			}
			if (arr[hi] == '0')
			{
				hi--;
			}

			if (lo <= hi && arr[lo] == '0' && arr[hi] == '1')
			{
				arr[lo] = '1';
				arr[hi] = '0';
			}
		}

		arr[lo - 1] = '0';
		arr[^1] = '1';

		return new string(arr);
	}
}