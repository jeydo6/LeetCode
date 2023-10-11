using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _1354
	{
		public static bool IsPossible(int[] target)
		{
			if (target.Length == 1)
			{
				return target[0] == 1;
			}

			var pqueue = new PriorityQueue<int, int>();

			var totalSum = 0;
			for (var i = 0; i < target.Length; i++)
			{
				totalSum += target[i];
				pqueue.Enqueue(target[i], -target[i]);
			}

			while (pqueue.Peek() > 1)
			{
				var largest = pqueue.Dequeue();
				var rest = totalSum - largest;

				if (rest == 1)
				{
					return true;
				}
				var x = largest % rest;

				if (x == 0 || x == largest)
				{
					return false;
				}
				pqueue.Enqueue(x, -x);
				totalSum = totalSum - largest + x;
			}

			return true;
		}
	}
}
