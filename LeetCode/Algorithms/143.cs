﻿namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _143
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

	public static void ReorderList(ListNode head)
	{
		if (head?.next == null)
		{
			return;
		}

		var p1 = head;
		var p2 = head;
		while (p2.next != null && p2.next.next != null)
		{
			p1 = p1.next;
			p2 = p2.next.next;
		}

		var preMiddle = p1;
		var preCurrent = p1.next;
		while (preCurrent.next != null)
		{
			var current = preCurrent.next;
			preCurrent.next = current.next;
			current.next = preMiddle.next;
			preMiddle.next = current;
		}

		p1 = head;
		p2 = preMiddle.next;
		while (p1 != preMiddle)
		{
			preMiddle.next = p2.next;
			p2.next = p1.next;
			p1.next = p2;
			p1 = p2.next;
			p2 = preMiddle.next;
		}
	}
}