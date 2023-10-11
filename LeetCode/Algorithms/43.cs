using System.Text;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _43
	{
		public static string Multiply(string num1, string num2)
		{
			var positions = new int[num1.Length + num2.Length];
			for (var i = num1.Length - 1; i >= 0; i--)
			{
				for (var j = num2.Length - 1; j >= 0; j--)
				{
					var m = (num1[i] - '0') * (num2[j] - '0');
					var p1 = i + j;
					var p2 = i + j + 1;

					var sum = m + positions[p2];
					positions[p1] += sum / 10;
					positions[p2] = sum % 10;
				}
			}
			var sb = new StringBuilder();
			foreach (var p in positions)
			{
				if (!(sb.Length == 0 && p == 0))
				{
					sb.Append(p);
				}
			}
			return sb.Length == 0 ? "0" : sb.ToString();
		}
	}
}
