using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1642
{
	public static int FurthestBuilding(int[] heights, int bricks, int ladders)
	{
		var ladderAllocations = new PriorityQueue<int, int>();
		for (var i = 0; i < heights.Length - 1; i++)
		{
			var climb = heights[i + 1] - heights[i];
			if (climb <= 0)
			{
				continue;
			}

			ladderAllocations.Enqueue(climb, climb);
			if (ladderAllocations.Count <= ladders)
			{
				continue;
			}

			bricks -= ladderAllocations.Dequeue();
			if (bricks < 0)
			{
				return i;
			}
		}
		return heights.Length - 1;
	}
}