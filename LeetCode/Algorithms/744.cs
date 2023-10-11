namespace LeetCode.Algorithms;

// EASY
internal class _744
{
	public static char NextGreatestLetter(char[] letters, char target)
	{
		var lo = 0;
		var hi = letters.Length - 1;
		while (lo <= hi)
		{
			var mid = lo + (hi - lo) / 2;
			if (letters[mid] <= target)
			{
				lo = mid + 1;
			}
			else
			{
				hi = mid - 1;
			}
		}

		return lo == letters.Length ? letters[0] : letters[lo];
	}
}
