namespace LeetCode.Algorithms
{
	// EASY
	internal class _203
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

		public static ListNode RemoveElements(ListNode head, int val)
		{
			if (head == null)
			{
				return null;
			}
			head.next = RemoveElements(head.next, val);
			return head.val == val ? head.next : head;
		}
	}
}
