namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _82
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

		public static ListNode DeleteDuplicates(ListNode head)
		{
			var sentinel = new ListNode(0, head);
			var prev = sentinel;
			while (head != null)
			{
				if (head.next != null && head.val == head.next.val)
				{
					while (head.next != null && head.val == head.next.val)
					{
						head = head.next;
					}
					prev.next = head.next;
				}
				else
				{
					prev = prev.next;
				}
				head = head.next;
			}
			return sentinel.next;
		}
	}
}
