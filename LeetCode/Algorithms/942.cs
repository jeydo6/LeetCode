namespace LeetCode.Algorithms
{
	internal class _942
	{
		public static int[] DiStringMatch(string s)
		{
			var min = 0;
			var max = s.Length;
			var result = new int[s.Length + 1];
			for (var i = 0; i < s.Length; i++)
			{
				if (s[i] == 'I')
				{
					result[i] = min++;
				}
				else
				{
					result[i] = max--;
				}
			}
			result[s.Length] = min;
			return result;
		}
	}
}