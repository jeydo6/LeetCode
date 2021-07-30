namespace LeetCode.Algorithms
{
	class _1720
	{
		public static int[] Decode(int[] encoded, int first)
		{
			var result = new int[encoded.Length + 1];

			result[0] = first;
			for (var i = 0; i < encoded.Length; i++)
			{
				result[i + 1] = result[i] ^ encoded[i];
			}

			return result;
		}
	}
}
