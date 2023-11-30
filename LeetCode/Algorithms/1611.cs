namespace LeetCode.Algorithms;

// HARD
internal sealed class _1611
{
    public static int MinimumOneBitOperations(int n)
    {
        var result = n;
        result ^= result >> 16;
        result ^= result >> 8;
        result ^= result >> 4;
        result ^= result >> 2;
        result ^= result >> 1;
        return result;
    }
}