using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUm
	internal class _1229
	{
		public static IList<int> MinAvailableDuration(int[][] slots1, int[][] slots2, int duration)
		{
			var slots = new PriorityQueue<int[], int>();

			for (var i = 0; i < slots1.Length; i++)
			{
				if (slots1[i][1] - slots1[i][0] >= duration)
				{
					slots.Enqueue(slots1[i], slots1[i][0]);
				}
			}

			for (var i = 0; i < slots2.Length; i++)
			{
				if (slots2[i][1] - slots2[i][0] >= duration)
				{
					slots.Enqueue(slots2[i], slots2[i][0]);
				}
			}

			while (slots.Count > 1)
			{
				var slot1 = slots.Dequeue();
				var slot2 = slots.Peek();
				if (slot1[1] >= slot2[0] + duration)
				{
					return new List<int> { slot2[0], slot2[0] + duration };
				}

			}
			return new List<int>();
		}
	}
}
