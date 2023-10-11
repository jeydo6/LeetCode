using System;

namespace LeetCode.Algorithms
{
	class _1374
	{
		public static string GenerateTheString(int n)
		{
			var chars = new char[n];
			Array.Fill(chars, 'a');
			if (n % 2 == 0)
			{
				chars[0] = 'b';
			}
			return new string(chars);
		}
	}
}
