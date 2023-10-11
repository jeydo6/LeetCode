using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _223
{
	public static int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
	{
		var left = Math.Max(ax1, bx1);
		var right = Math.Min(ax2, bx2);
		var xOverlap = right - left;

		var top = Math.Min(ay2, by2);
		var bottom = Math.Max(ay1, by1);
		var yOverlap = top - bottom;

		var areaOfOverlap = xOverlap > 0 && yOverlap > 0 ? xOverlap * yOverlap : 0;
		var areaOfA = (ay2 - ay1) * (ax2 - ax1);
		var areaOfB = (by2 - by1) * (bx2 - bx1);

		return areaOfA + areaOfB - areaOfOverlap;
	}
}
