namespace LeetCode.Algorithms;

// MEDIUM
internal class _725
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

	public static ListNode[] SplitListToParts(ListNode head, int k)
	{
		var length = 0;
		for (var item = head; item != null; item = item.next)
		{
			length++;
		}

		var n = length / k;
		var r = length % k;

		var node = head;
		var prev = default(ListNode);
		var parts = new ListNode[k];
		for (var i = 0; node != null && i < k; i++, r--)
		{
			parts[i] = node;
			for (var j = 0; j < n + (r > 0 ? 1 : 0); j++)
			{
				prev = node;
				node = node.next;
			}
			prev.next = null;
		}
		return parts;
	}
}
