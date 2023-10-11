using System.Text;

namespace LeetCode.Algorithms;

// EASY
internal class _168
{
    public static string ConvertToTitle(int columnNumber)
    {
        var sb = new StringBuilder();
        while(columnNumber > 0)
        {
            sb.Append((char)((--columnNumber) % 26 + 'A'));
            columnNumber /= 26;
        }

        var result = new char[sb.Length];
        for (var i = 0; i < sb.Length; i++)
        {
            result[^(i + 1)] = sb[i];
        }
        return new string(result);
    }
}