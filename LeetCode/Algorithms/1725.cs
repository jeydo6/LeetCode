using System;

namespace LeetCode.Algorithms
{
	class _1725
	{
		//public static int CountGoodRectangles(int[][] rectangles)
		//{
		//	var maxLength = 0;
		//	var lengths = new int[rectangles.Length];
		//	for (var i = 0; i < rectangles.Length; i++)
		//	{
		//		lengths[i] = Math.Min(rectangles[i][0], rectangles[i][1]);
		//		if (lengths[i] > maxLength)
		//		{
		//			maxLength = lengths[i];
		//		}
		//	}

		//	var result = 0;
		//	for (var i = 0; i < rectangles.Length; i++)
		//	{
		//		if (lengths[i] == maxLength)
		//		{
		//			result++;
		//		}
		//	}
		//	return result;
		//}

		public static int CountGoodRectangles(int[][] rectangles)
		{
			var max = 0;
			var result = 0;
			foreach (var rectangle in rectangles)
			{
				var temp = Math.Min(rectangle[0], rectangle[1]);
				if (temp > max)
				{
					result = 1;
					max = temp;
				}
				else if (temp == max)
				{
					result++;
				}
			}
			return result;
		}
	}
}
