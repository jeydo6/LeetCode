namespace LeetCode.Algorithms;

// MEDIUM
internal class _2095
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

	public static ListNode DeleteMiddle(ListNode head)
	{
		if (head.next == null)
		{
			return null;
		}

		var slow = head;
		var fast = head.next.next;

		while (fast != null && fast.next != null)
		{
			slow = slow.next;
			fast = fast.next.next;
		}

		slow.next = slow.next.next;
		return head;
	}
}
