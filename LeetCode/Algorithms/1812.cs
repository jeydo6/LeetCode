namespace LeetCode.Algorithms
{
	class _1812
	{
		public static bool SquareIsWhite(string coordinates)
		{
			return (coordinates[0] - 'a' + coordinates[1] - '1') % 2 == 1;
		}
	}
}
