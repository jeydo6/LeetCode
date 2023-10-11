using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _871
	{
		public static int MinRefuelStops(int target, int startFuel, int[][] stations)
		{
			var pqueue = new PriorityQueue<int, int>();

			var result = 0;
			var prev = 0;
			for (var i = 0; i < stations.Length; i++)
			{
				var location = stations[i][0];
				var capacity = stations[i][1];
				startFuel -= location - prev;

				while (pqueue.Count > 0 && startFuel < 0)
				{
					startFuel += pqueue.Dequeue();
					result++;
				}

				if (startFuel < 0)
				{
					return -1;
				}

				pqueue.Enqueue(capacity, -capacity);
				prev = location;
			}

			startFuel -= target - prev;
			while (pqueue.Count > 0 && startFuel < 0)
			{
				startFuel += pqueue.Dequeue();
				result++;
			}

			if (startFuel < 0)
			{
				return -1;
			}

			return result;
		}
	}
}
