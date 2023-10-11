using System;
using System.Text;

namespace LeetCode.Algorithms;

// EASY
internal class _800
{
	public static string SimilarRGB(string color)
	{
		var sb = new StringBuilder();
		sb.Append('#');

		for (var i = 1; i < 6; i += 2)
		{
			var target = FindTarget(color[i..(i + 2)]);
			sb.Append(target);
		}

		return sb.ToString();
	}

	private static string FindTarget(string colorSection)
	{
		var num = Convert.ToInt32(colorSection, 16);

		var result = -1;
		var minDifference = int.MaxValue;

		for (var i = 0; i < 16; i++)
		{
			var currentDifference = (i * 17 - num) * (i * 17 - num);
			if (currentDifference < minDifference)
			{
				minDifference = currentDifference;
				result = i;
			}
		}

		return Convert.ToString(result, 16);
	}
}
