namespace LeetCode.Algorithms;

// MEDIUM
internal class _1759
{
    private const long Modulo = 1_000_000_007;

    public static int CountHomogenous(string s)
    {
        var result = 0L;

        var streak = 0L;
        for (var i = 0; i < s.Length; i++)
        {
            if (i == 0 || s[i] == s[i - 1])
            {
                streak++;
            }
            else
            {
                streak = 1;
            }

            result = (result + streak) % Modulo;
        }

        return (int)result;
    }
}