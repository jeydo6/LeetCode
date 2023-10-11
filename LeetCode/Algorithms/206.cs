namespace LeetCode.Algorithms
{
	// EASY
	internal class _206
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

		public static ListNode ReverseList(ListNode head)
		{
			ListNode newHead = null;
			while (head != null)
			{
				var next = head.next;
				head.next = newHead;
				newHead = head;
				head = next;
			}
			return newHead;
		}
	}
}
