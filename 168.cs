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

        var 
        return ans.reverse().toString
    }
}