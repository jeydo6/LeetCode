namespace LeetCode.Algorithms;

// EASY
internal class _459
{
    public bool RepeatedSubstringPattern(string s)
    {
        return (s + s)[1..^1].Contains(s);
    }
}