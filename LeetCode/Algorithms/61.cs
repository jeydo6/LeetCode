namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _61
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

		public static ListNode RotateRight(ListNode head, int k)
		{
			if (head == null)
			{
				return null;
			}
			if (head.next == null)
			{
				return head;
			}

			int n;
			var oldTail = head;
			for (n = 1; oldTail.next != null; n++)
			{
				oldTail = oldTail.next;
			}
			oldTail.next = head;

			var newTail = head;
			for (var i = 0; i < n - k % n - 1; i++)
			{
				newTail = newTail.next;
			}

			var newHead = newTail.next;
			newTail.next = null;
			return newHead;
		}
	}
}
