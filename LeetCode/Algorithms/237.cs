namespace LeetCode.Algorithms;

// MEDIUM
internal class _237
{
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}

	public static void DeleteNode(ListNode node)
	{
		var nextNode = node.next;
		node.val = nextNode.val;
		node.next = nextNode.next;
		nextNode.next = null;
	}
}
