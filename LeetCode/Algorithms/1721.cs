namespace LeetCode.Algorithms;

// MEDIUM
internal class _1721
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

	public static ListNode SwapNodes(ListNode head, int k)
	{
		var frontNode = default(ListNode);
		var endNode = default(ListNode);

		var length = 0;
		var currentNode = head;
		while (currentNode != null)
		{
			length++;
			if (endNode != null)
			{
				endNode = endNode.next;
			}

			if (length == k)
			{
				frontNode = currentNode;
				endNode = head;
			}
			currentNode = currentNode.next;
		}

		(frontNode.val, endNode.val) = (endNode.val, frontNode.val);

		return head;
	}
}
