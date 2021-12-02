namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _328
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

		public static ListNode OddEvenList(ListNode head)
		{
			if (head != null)
			{
				var odd = head;
				var even = head.next;
				var temp = even;
				while (even != null && even.next != null)
				{
					odd.next = odd.next.next;
					even.next = even.next.next;
					odd = odd.next;
					even = even.next;
				}
				odd.next = temp;
			}
			return head;
		}
	}
}
