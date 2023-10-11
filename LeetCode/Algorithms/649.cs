using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _649
{
	public static string PredictPartyVictory(string senate)
	{
		var rCount = 0;
		var dCount = 0;

		var dFloatingBan = 0;
		var rFloatingBan = 0;

		var queue = new Queue<char>();
		foreach (var ch in senate)
		{
			queue.Enqueue(ch);
			if (ch == 'R') rCount++;
			else dCount++;
		}

		while (rCount > 0 && dCount > 0)
		{
			var current = queue.Dequeue();
			if (current == 'D')
			{
				if (dFloatingBan > 0)
				{
					dFloatingBan--;
					dCount--;
				}
				else
				{
					rFloatingBan++;
					queue.Enqueue('D');
				}
			}
			else
			{
				if (rFloatingBan > 0)
				{
					rFloatingBan--;
					rCount--;
				}
				else
				{
					dFloatingBan++;
					queue.Enqueue('R');
				}
			}
		}

		return rCount > 0 ? "Radiant" : "Dire";
	}
}
