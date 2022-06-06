namespace LeetCode.Algorithms
{
	// EASY
	internal class _160
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}

		public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
		{
			var nodeA = headA;
			var nodeB = headB;
			while (nodeA != nodeB)
			{
				nodeA = nodeA == null ? headB : nodeA.next;
				nodeB = nodeB == null ? headA : nodeB.next;
			}
			return nodeA;
		}
	}
}
