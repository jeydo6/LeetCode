namespace LeetCode.Algorithms;

// HARD
internal sealed class _2147
{
    private const int Modulo = 1_000_000_007;

    public static int NumberOfWays(string corridor)
    {
        var zero = 0;
        var one = 0;
        var two = 1;

        foreach (var thing in corridor)
        {
            if (thing == 'S')
            {
                zero = one;
				(one, two) = (two, one);
			}
			else
            {
                two = (two + zero) % Modulo;
            }
        }

        return zero;
    }
}