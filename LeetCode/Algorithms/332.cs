using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _332
{
	public static IList<string> FindItinerary(IList<IList<string>> tickets)
	{
		var targets = new Dictionary<string, PriorityQueue<string, string>>();
		foreach (var ticket in tickets)
		{
			if (!targets.ContainsKey(ticket[0]))
			{
				targets[ticket[0]] = new PriorityQueue<string, string>();
			}
			targets[ticket[0]].Enqueue(ticket[1], ticket[1]);
		}

		var route = new LinkedList<string>();
		var stack = new Stack<string>();
		stack.Push("JFK");
		while (stack.Count > 0)
		{
			while (targets.ContainsKey(stack.Peek()) && targets[stack.Peek()].Count > 0)
			{
				stack.Push(targets[stack.Peek()].Dequeue());
			}

			route.AddFirst(stack.Pop());
		}
		return new List<string>(route);
	}
}
