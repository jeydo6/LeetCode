namespace LeetCode.Algorithms
{
	// EASY
	internal class _1290
	{
		public class ListNode
		{
			public ListNode(int val = 0, ListNode next = null)
			{
				this.val = val;
				this.next = next;
			}

			public int val;
			public ListNode next;
		}

		public static int GetDecimalValue(ListNode head)
		{
			var result = head.val;
			while (head.next != null)
			{
				result = (result << 1) | head.next.val;
				head = head.next;
			}
			return result;
		}
	}
}
