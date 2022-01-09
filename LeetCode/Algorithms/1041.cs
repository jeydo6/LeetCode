namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1041
	{
		public static bool IsRobotBounded(string instructions)
		{
			var d = new int[][]
			{
				new int[] { 0, 1 },
				new int[] { 1, 0 },
				new int[] { 0, -1 },
				new int[] { -1, 0 }
			};
			var x = 0;
			var y = 0;
			var i = 0;
			for (var j = 0; j < instructions.Length; j++)
			{
				if (instructions[j] == 'R')
				{
					i = (i + 1) % 4;
				}
				else if (instructions[j] == 'L')
				{
					i = (i + 3) % 4;
				}
				else
				{
					x += d[i][0];
					y += d[i][1];
				}
			}
			return (x == 0 && y == 0) || i > 0;
		}
	}
}
