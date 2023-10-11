namespace LeetCode.Algorithms;

// EASY
internal class _141
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

	public static bool HasCycle(ListNode head)
	{
		if (head == null)
		{
			return false;
		}
		var slow = head;
		var fast = head;
		while (fast.next != null && fast.next.next != null)
		{
			slow = slow.next;
			fast = fast.next.next;
			if (slow == fast)
			{
				return true;
			}
		}
		return false;
	}
}
