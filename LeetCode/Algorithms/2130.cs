using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2130
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

	public static int PairSum(ListNode head)
	{
		var slow = head;
		var fast = head;

		while (fast != null && fast.next != null)
		{
			fast = fast.next.next;
			slow = slow.next;
		}

		var prev = default(ListNode);
		while (slow != null)
		{
			var next = slow.next;
			slow.next = prev;
			prev = slow;
			slow = next;
		}

		var start = head;
		var result = 0;
		while (prev != null)
		{
			result = Math.Max(result, start.val + prev.val);
			prev = prev.next;
			start = start.next;
		}

		return result;
	}
}
