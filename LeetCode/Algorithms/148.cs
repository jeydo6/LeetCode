namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _148
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

		public static ListNode SortList(ListNode head)
		{
			if (head == null || head.next == null)
			{
				return head;
			}

			ListNode prev = null;
			var slow = head;
			var fast = head;

			while (fast != null && fast.next != null)
			{
				prev = slow;
				slow = slow.next;
				fast = fast.next.next;
			}

			prev.next = null;

			var l1 = SortList(head);
			var l2 = SortList(slow);

			return MergeList(l1, l2);
		}

		private static ListNode MergeList(ListNode l1, ListNode l2)
		{
			var l = new ListNode(0);
			var p = l;

			while (l1 != null && l2 != null)
			{
				if (l1.val < l2.val)
				{
					p.next = l1;
					l1 = l1.next;
				}
				else
				{
					p.next = l2;
					l2 = l2.next;
				}
				p = p.next;
			}

			if (l1 != null)
			{
				p.next = l1;
			}

			if (l2 != null)
			{
				p.next = l2;
			}

			return l.next;
		}
	}
}
