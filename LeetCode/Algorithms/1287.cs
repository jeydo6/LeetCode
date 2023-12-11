namespace LeetCode.Algorithms;

// EASY
internal sealed class _1287
{
    public static int FindSpecialInteger(int[] arr)
    {
        var size = arr.Length / 4;
        for (var i = 0; i < arr.Length - size; i++)
        {
            if (arr[i] == arr[i + size])
            {
                return arr[i];
            }
        }

        return -1;
    }
}