namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _92
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

		public static ListNode ReverseBetween(ListNode head, int left, int right)
		{
			if (head == null)
			{
				return null;
			}

			var current = head;
			var previous = default(ListNode);
			while (left > 1)
			{
				previous = current;
				current = current.next;
				left--;
				right--;
			}

			var connection = previous;
			var tail = current;

			while (right > 0)
			{
				var third = current.next;
				current.next = previous;
				previous = current;
				current = third;
				right--;
			}

			if (connection != null)
			{
				connection.next = previous;
			}
			else
			{
				head = previous;
			}

			tail.next = current;
			return head;
		}
	}
}
