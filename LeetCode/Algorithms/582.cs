using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _582
{
	public static IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill)
	{
		var dict = new Dictionary<int, IList<int>>();
		for (var i = 0; i < ppid.Count; i++)
		{
			if (ppid[i] > 0)
			{
				if (!dict.ContainsKey(ppid[i]))
				{
					dict[ppid[i]] = new List<int>();
				}

				dict[ppid[i]].Add(pid[i]);
			}
		}

		var result = new List<int>();

		var queue = new Queue<int>();
		queue.Enqueue(kill);
		while (queue.Count > 0)
		{
			var process = queue.Dequeue();
			result.Add(process);
			if (dict.ContainsKey(process))
			{
				foreach (var id in dict[process])
				{
					queue.Enqueue(id);
				}
			}
		}
		return result;
	}
}
