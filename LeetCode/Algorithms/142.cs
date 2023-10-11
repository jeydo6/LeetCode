namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _142
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x)
			{
				val = x;
				next = null;
			}
		}

		public static ListNode DetectCycle(ListNode head)
		{
			var slow = head;
			var fast = head;
			while (fast != null && fast.next != null)
			{
				fast = fast.next.next;
				slow = slow.next;

				if (fast == slow)
				{
					var slow2 = head;
					while (slow2 != slow)
					{
						slow = slow.next;
						slow2 = slow2.next;
					}
					return slow;
				}
			}
			return null;
		}
	}
}
