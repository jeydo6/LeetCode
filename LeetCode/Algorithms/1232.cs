namespace LeetCode.Algorithms;

// EASY
internal class _1232
{
	public static bool CheckStraightLine(int[][] coordinates)
	{
		var dx0 = coordinates[1][0] - coordinates[0][0];
		var dy0 = coordinates[1][1] - coordinates[0][1];
		for (var i = 2; i < coordinates.Length; i++)
		{
			var dxi = coordinates[i][0] - coordinates[0][0];
			var dyi = coordinates[i][1] - coordinates[0][1];
			if (dy0 * dxi != dx0 * dyi)
			{
				return false;
			}
		}
		return true;
	}
}
