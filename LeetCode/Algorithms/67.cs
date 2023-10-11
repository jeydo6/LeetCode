using System.Text;

namespace LeetCode.Algorithms;

// EASY
internal class _67
{
	public static string AddBinary(string a, string b)
	{
		var sb = new StringBuilder();
		var i = a.Length - 1;
		var j = b.Length - 1;
		var carry = 0;
		while (i >= 0 || j >= 0)
		{
			var sum = carry;
			if (i >= 0)
			{
				sum += a[i--] - '0';
			}
			if (j >= 0)
			{
				sum += b[j--] - '0';
			}
			sb.Append(sum % 2);
			carry = sum / 2;
		}
		if (carry != 0)
		{
			sb.Append(carry);
		}
		var result = new char[sb.Length];
		for (var k = 0; k < sb.Length; k++)
		{
			result[^(k + 1)] = sb[k];
		}
		return new string(result);
	}
}
