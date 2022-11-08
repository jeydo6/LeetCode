using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _339
{
	public abstract class NestedInteger
	{
		public abstract bool IsInteger();
		public abstract int GetInteger();
		public abstract void SetInteger();
		public abstract void Add();
		public abstract IList<NestedInteger> GetList();
	}

	public static int DepthSum(IList<NestedInteger> nestedList)
	{
		var result = 0;

		var depth = 1;
		var queue = new Queue<NestedInteger>(nestedList);
		while (queue.Count > 0)
		{
			var count = queue.Count;
			for (var i = 0; i < count; i++)
			{
				var nested = queue.Dequeue();
				if (nested.IsInteger())
				{
					result += nested.GetInteger() * depth;
				}
				else
				{
					foreach (var item in nested.GetList())
					{
						queue.Enqueue(item);
					}
				}
			}
			depth++;
		}

		return result;
	}
}
