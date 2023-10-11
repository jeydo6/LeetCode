using System.Linq;

namespace LeetCode.Algorithms
{
	class _1946
	{
		public static string MaximumNumber(string number, int[] change)
		{
			var result = number
				.Select(ch => ch - '0')
				.ToArray();

			var changed = false;
			for (var i = 0; i < number.Length; i++)
			{
				var before = number[i] - '0';
				var after = change[before];

				if (changed)
				{
					if (after >= before)
					{
						result[i] = after;
					}
					else
					{
						break;
					}
				}
				else
				{
					if (after > before)
					{
						result[i] = after;
						changed = true;
					}
				}
			}

			return string.Concat(result);
		}
	}
}
