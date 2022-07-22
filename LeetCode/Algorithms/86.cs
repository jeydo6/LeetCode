namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _86
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

		public static ListNode Partition(ListNode head, int x)
		{
			var beforeHead = new ListNode(0);
			var before = beforeHead;
			var afterHead = new ListNode(0);
			var after = afterHead;

			while (head != null)
			{
				if (head.val < x)
				{
					before.next = head;
					before = before.next;
				}
				else
				{
					after.next = head;
					after = after.next;
				}

				head = head.next;
			}

			after.next = null;
			before.next = afterHead.next;

			return beforeHead.next;
		}
	}
}
