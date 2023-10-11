namespace Leetcode.Algorithms
{
	public class _876
	{
		public class ListNode
		{
			public ListNode(int x)
			{
				val = x;
			}

			public int val;

			public ListNode next;
		}

		public static ListNode MiddleNode(ListNode head)
		{
			var slow = head;
			var fast = head;

			while (fast != null && fast.next != null)
			{
				slow = slow.next;
				fast = fast.next.next;
			}

			return slow;
		}
	}
}
