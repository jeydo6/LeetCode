namespace LeetCode.Algorithms;

// EASY
internal sealed class _191
{
	public static int HammingWeight(uint n)
	{
		var count = 0u;
		while (n != 0)
		{
			count += n & 1;
			n >>= 1;
		}
		return (int)count;
	}
}
