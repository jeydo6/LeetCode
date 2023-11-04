namespace LeetCode.Algorithms;

// MEDIUM
internal class _1503
{
    public static int GetLastMoment(int n, int[] left, int[] right)
    {
        var result = 0;

        for (var i = 0; i < left.Length; i++)
        {
            if (left[i] > result)
            {
                result = left[i];
            }
        }
        for (var i = 0; i < right.Length; i++)
        {
            if (n - right[i] > result)
            {
                result = n - right[i];
            }
        }

        return result;
    }
}