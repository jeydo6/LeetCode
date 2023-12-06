namespace LeetCode.Algorithms;

// EASY
internal sealed class _1716
{
    public static int TotalMoney(int n)
    {
        var k = n / 7;
        var first = 28;
        var last = 28 + (k - 1) * 7;

        var monday = 1 + k;
        var finalWeek = 0;
        for (var day = 0; day < n % 7; day++)
        {
            finalWeek += monday + day;
        }

        return k * (first + last) / 2 + finalWeek;
    }
}