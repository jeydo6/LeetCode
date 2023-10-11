using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1007
	{
		public static int MinDominoRotations(int[] tops, int[] bottoms)
		{
			var rotations = MinDominoRotations(tops, bottoms, tops[0]);
			if (rotations != -1 || tops[0] == bottoms[0])
			{
				return rotations;
			}
			else
			{
				return MinDominoRotations(tops, bottoms, bottoms[0]);
			}
		}

		private static int MinDominoRotations(int[] tops, int[] bottoms, int val)
		{
			var rotationsTops = 0;
			var rotationsBottoms = 0;
			for (var i = 0; i < tops.Length; i++)
			{
				if (tops[i] != val && bottoms[i] != val)
				{
					return -1;
				}
				else if (tops[i] != val)
				{
					rotationsTops++;
				}
				else if (bottoms[i] != val)
				{
					rotationsBottoms++;
				}
			}
			return Math.Min(rotationsTops, rotationsBottoms);
		}
	}
}
