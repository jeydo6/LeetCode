using System;

namespace Leetcode.Algorithms
{
	// EASY
	internal class _821
	{
		public static int[] ShortestToChar(string str, char ch)
		{
			var arr = new int[str.Length];
			for (var i = 0; i < str.Length; i++)
			{
				arr[i] = int.MaxValue;
			}

			var distance = int.MaxValue;
			for (var i = 0; i < str.Length; i++)
			{
				if (str[i] == ch)
				{
					distance = 0;
				}
				else
				{
					distance++;
				}

				arr[i] = Math.Min(arr[i], distance);
			}

			distance = int.MaxValue;
			for (var i = str.Length - 1; i >= 0; i--)
			{
				if (str[i] == ch)
				{
					distance = 0;
				}
				else
				{
					distance++;
				}

				arr[i] = Math.Min(arr[i], distance);
			}

			return arr;
		}
	}
}
