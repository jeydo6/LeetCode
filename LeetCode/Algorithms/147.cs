namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _147
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

		public static ListNode InsertionSortList(ListNode head)
		{
			if (head == null)
			{
				return head;
			}

			var result = new ListNode(0);
			var current = head;
			var prev = result;
			while (current != null)
			{
				var next = current.next;
				while (prev.next != null && prev.next.val < current.val)
				{
					prev = prev.next;
				}
				current.next = prev.next;
				prev.next = current;
				prev = result;
				current = next;
			}
			return result.next;
		}
	}
}
