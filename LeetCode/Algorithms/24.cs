namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _24
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

		public static ListNode SwapPairs(ListNode head)
		{
			if (head == null || head.next == null)
			{
				return head;
			}

			var next = head.next;
			head.next = SwapPairs(head.next.next);
			next.next = head;
			return next;
		}
	}
}
