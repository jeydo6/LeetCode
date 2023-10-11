using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _841
{
	public static bool CanVisitAllRooms(IList<IList<int>> rooms)
	{
		var seen = new bool[rooms.Count];
		seen[0] = true;

		var stack = new Stack<int>();
		stack.Push(0);

		while (stack.Count > 0)
		{
			var node = stack.Pop();
			foreach (var item in rooms[node])
			{
				if (!seen[item])
				{
					seen[item] = true;
					stack.Push(item);
				}
			}
		}

		for (var i = 0; i < seen.Length; i++)
		{
			if (!seen[i])
			{
				return false;
			}
		}

		return true;
	}
}
