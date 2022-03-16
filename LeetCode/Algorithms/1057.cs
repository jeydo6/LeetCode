using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1057
	{
		public static int[] AssignBikes(int[][] workers, int[][] bikes)
		{
			var minDistance = int.MaxValue;
			var distanceToPairs = new Dictionary<int, IList<(int Worker, int Bike)>>();

			for (var worker = 0; worker < workers.Length; worker++)
			{
				for (var bike = 0; bike < bikes.Length; bike++)
				{
					var distance = FindDistance(workers[worker], bikes[bike]);
					if (!distanceToPairs.ContainsKey(distance))
					{
						distanceToPairs[distance] = new List<(int Worker, int Bike)>();
					}
					distanceToPairs[distance].Add((worker, bike));
					minDistance = Math.Min(minDistance, distance);
				}
			}

			var currentDistance = minDistance;
			var bikeStatus = new bool[bikes.Length];
			var workerStatus = new int[workers.Length];
			Array.Fill(workerStatus, -1);

			var pairCount = 0;
			while (pairCount != workers.Length)
			{
				if (!distanceToPairs.ContainsKey(currentDistance))
				{
					currentDistance++;
					continue;
				}

				foreach (var (worker, bike) in distanceToPairs[currentDistance])
				{
					if (workerStatus[worker] == -1 && !bikeStatus[bike])
					{
						bikeStatus[bike] = true;
						workerStatus[worker] = bike;
						pairCount++;
					}
				}
				currentDistance++;
			}

			return workerStatus;
		}

		private static int FindDistance(int[] worker, int[] bike)
		{
			return Math.Abs(worker[0] - bike[0]) + Math.Abs(worker[1] - bike[1]);
		}
	}
}
