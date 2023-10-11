namespace LeetCode.Algorithms;
internal class _443
{
	public static int Compress(char[] chars)
	{
		var i = 0;
		var result = 0;
		while (i < chars.Length)
		{
			var groupLength = 1;
			while (i + groupLength < chars.Length && chars[i + groupLength] == chars[i])
			{
				groupLength++;
			}
			chars[result++] = chars[i];
			if (groupLength > 1)
			{
				foreach (var ch in groupLength.ToString())
				{
					chars[result++] = ch;
				}
			}
			i += groupLength;
		}
		return result;
	}
}
