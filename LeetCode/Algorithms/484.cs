namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _484
	{
		public static int[] FindPermutation(string s)
		{
			var result = new int[s.Length + 1];
			result[0] = 1;

			var i = 1;
			while (i <= s.Length)
			{
				result[i] = i + 1;
				var j = i;
				if (s[i - 1] == 'D')
				{
					while (i <= s.Length && s[i - 1] == 'D')
					{
						i++;
					}

					var c = i;
					var k = j - 1;
					while (k <= i - 1)
					{
						result[k++] = c--;
					}
				}
				else
				{
					i++;
				}
			}

			return result;
		}
	}
}
