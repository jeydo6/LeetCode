using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _23
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int val = 0, ListNode next = null)
			{
				this.val = val;
				this.next = next;
			}
		}

		public static ListNode MergeKLists(ListNode[] lists)
		{
			if (lists == null || lists.Length == 0)
			{
				return null;
			}

			var queue = new PriorityQueue<ListNode, int>(lists.Length);

			var dummy = new ListNode(0);
			var tail = dummy;

			foreach (var node in lists)
			{
				if (node != null)
				{
					queue.Enqueue(node, node.val);
				}
			}

			while (queue.Count > 0)
			{
				tail.next = queue.Dequeue();
				tail = tail.next;

				if (tail.next != null)
				{
					queue.Enqueue(tail.next, tail.next.val);
				}

			}
			return dummy.next;
		}
	}
}
