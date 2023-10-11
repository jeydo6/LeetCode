namespace LeetCode.Algorithms;

// EASY
internal class _1323
{
	public static int Maximum69Number(int number)
	{
		var chars = number
			.ToString()
			.ToCharArray();

		for (var i = 0; i < chars.Length; i++)
		{
			if (chars[i] == '6')
			{
				chars[i] = '9';
				break;
			}
		}

		var result = new string(chars);
		return int.Parse(result);
	}
}
