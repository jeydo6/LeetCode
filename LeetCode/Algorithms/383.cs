namespace LeetCode.Algorithms
{
	// EASY
	internal class _383
	{
		public static bool CanConstruct(string ransomNote, string magazine)
		{
			var arr = new int[26];
			for (var i = 0; i < magazine.Length; i++)
			{
				arr[magazine[i] - 'a']++;
			}

			for (var i = 0; i < ransomNote.Length; i++)
			{
				if (--arr[ransomNote[i] - 'a'] < 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
