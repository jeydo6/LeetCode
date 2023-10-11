using System.Text;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _423
	{
		public static string OriginalDigits(string s)
		{
			var count = new char[26];
			for (var i = 0; i < s.Length; i++)
			{
				count[s[i] - 'a']++;
			}

			var output = new int[10];
			// letter "z" is present only in "zero"
			output[0] = count['z' - 'a'];
			// letter "w" is present only in "two"
			output[2] = count['w' - 'a'];
			// letter "u" is present only in "four"
			output[4] = count['u' - 'a'];
			// letter "x" is present only in "six"
			output[6] = count['x' - 'a'];
			// letter "g" is present only in "eight"
			output[8] = count['g' - 'a'];
			// letter "h" is present only in "three" and "eight"
			output[3] = count['h' - 'a'] - output[8];
			// letter "f" is present only in "five" and "four"
			output[5] = count['f' - 'a'] - output[4];
			// letter "s" is present only in "seven" and "six"
			output[7] = count['s' - 'a'] - output[6];
			// letter "i" is present in "nine", "five", "six", and "eight"
			output[9] = count['i' - 'a'] - output[5] - output[6] - output[8];
			// letter "n" is present in "one", "nine", and "seven"
			output[1] = count['n' - 'a'] - output[7] - 2 * output[9];

			var sb = new StringBuilder();
			for (var i = 0; i < output.Length; i++)
			{
				for (var j = 0; j < output[i] ; j++)
				{
					sb.Append(i);
				}
			}
			return sb.ToString();
		}
	}
}
