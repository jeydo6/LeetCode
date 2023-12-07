namespace LeetCode.Algorithms;

// EASY
internal sealed class _1903
{
    public static string LargestOddNumber(string num)
    {
        for (var i = num.Length - 1; i >= 0; i--)
        {
            if ((num[i] - '0') % 2 != 0)
            {
                return num[0..(i + 1)];
            }
        }

        return string.Empty;
    }
}