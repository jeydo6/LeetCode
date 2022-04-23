namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _19
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

		public static ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			var start = new ListNode(0)
			{
				next = head
			};
			var slow = start;
			var fast = start;

			for (var i = 0; i < n + 1; i++)
			{
				fast = fast.next;
			}

			while (fast != null)
			{
				slow = slow.next;
				fast = fast.next;
			}

			slow.next = slow.next.next;
			return start.next;
		}
	}
}
