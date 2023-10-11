using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1265
	{
		public abstract class ImmutableListNode
		{
			public abstract void PrintValue();
			public abstract ImmutableListNode GetNext();
		}

		public static void PrintLinkedListInReverse(ImmutableListNode head)
		{
			var stack = new Stack<ImmutableListNode>();
			var node = head;
			while (node != null)
			{
				stack.Push(node);
				node = node.GetNext();
			}

			while (stack.Count > 0)
			{
				node = stack.Pop();
				node.PrintValue();
			}
		}
	}
}
