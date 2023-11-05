namespace LeetCode.Algorithms;

// MEDIUM
internal class _1535
{
    public static int GetWinner(int[] arr, int k)
    {
        var max = arr[0];
        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        var current = arr[0];
        var winStreak = 0;

        for (var i = 1; i < arr.Length; i++)
        {
            var opponent = arr[i];

            if (current > opponent)
            {
                winStreak++;
            }
            else
            {
                current = opponent;
                winStreak = 1;
            }

            if (winStreak == k || current == max)
            {
                return current;
            }
        }

        return -1;
    }
}