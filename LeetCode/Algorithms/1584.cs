using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1584
	{
		public static int MinCostConnectPoints(int[][] points)
		{
			var n = points.Length;

			var mstCost = 0;
			var mst = new bool[n];

			var minDistance = new int[n];
			for (var i = 1; i < n; ++i)
			{
				minDistance[i] = int.MaxValue;
			}

			var edgesUsed = 0;
			while (edgesUsed < n)
			{
				var currentMinEdge = int.MaxValue;
				var currentNode = -1;

				for (var node = 0; node < n; ++node)
				{
					if (!mst[node] && currentMinEdge > minDistance[node])
					{
						currentMinEdge = minDistance[node];
						currentNode = node;
					}
				}

				mstCost += currentMinEdge;
				edgesUsed++;
				mst[currentNode] = true;

				for (var nextNode = 0; nextNode < n; ++nextNode)
				{
					var weight = Math.Abs(points[currentNode][0] - points[nextNode][0]) +
								 Math.Abs(points[currentNode][1] - points[nextNode][1]);

					if (!mst[nextNode] && minDistance[nextNode] > weight)
					{
						minDistance[nextNode] = weight;
					}
				}
			}

			return mstCost;
		}
	}
}
