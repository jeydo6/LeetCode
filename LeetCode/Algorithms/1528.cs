namespace LeetCode.Algorithms
{
	class _1528
	{
		public static string RestoreString(string str, int[] indices)
		{
			var result = new char[str.Length];

			for (var i = 0; i < str.Length; i++)
			{
				result[indices[i]] = str[i];
			}

			return new string(result);
		}
	}
}
