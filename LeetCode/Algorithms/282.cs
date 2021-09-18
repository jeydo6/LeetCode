using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	internal class _282
	{
		public static IList<string> AddOperators(string num, int target, string path = "", int position = 0, long evaluation = 0L, long multiplied = 0L)
		{
			var result = new List<string>();

			if (string.IsNullOrEmpty(num))
			{
				return result;
			}

			if (position == num.Length)
			{
				if (target == evaluation)
				{
					result.Add(path);
				}
				return result;
			}

			for (var i = position; i < num.Length; i++)
			{
				if (i != position && num[position] == '0')
				{
					break;
				}

				var current = long.Parse(num[position..(i + 1)]);
				if (position == 0)
				{
					result.AddRange(
						AddOperators(num, target, path + current, i + 1, current, current)
					);
				}
				else
				{
					result.AddRange(
						AddOperators(num, target, path + "+" + current, i + 1, evaluation + current, current)
					);
					result.AddRange(
						AddOperators(num, target, path + "-" + current, i + 1, evaluation - current, -current)
					);
					result.AddRange(
						AddOperators(num, target, path + "*" + current, i + 1, evaluation - multiplied + multiplied * current, multiplied * current)
					);
				}
			}

			return result;
		}
	}
}
