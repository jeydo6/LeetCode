using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1171
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

	public static ListNode RemoveZeroSumSublists(ListNode head)
	{
		var dummy = new ListNode(0, head);
		var current = dummy;
		var prefixSum = 0;
		var prefixSumToNode = new Dictionary<int, ListNode>();
		while (current != null)
		{
			prefixSum += current.val;

			if (prefixSumToNode.TryGetValue(prefixSum, out var prev))
			{
				current = prev.next;
				var p = prefixSum + current.val;
				while (p != prefixSum)
				{
					prefixSumToNode.Remove(p);
					current = current.next;
					p += current.val;
				}

				prev.next = current.next;
			}
			else
			{
				prefixSumToNode[prefixSum] = current;
			}

			current = current.next;
		}

		return dummy.next;
	}
}