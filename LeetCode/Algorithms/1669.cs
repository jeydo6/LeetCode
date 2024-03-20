namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1669
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

	public static ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
	{
		var lo = default(ListNode);
		var hi = list1;

		for (var index = 0; index < b; index++)
		{
			if (index == a - 1)
			{
				lo = hi;
			}

			hi = hi.next;
		}

		if (lo is null) return list1;

		lo.next = list2;

		while (list2.next != null)
		{
			list2 = list2.next;
		}

		list2.next = hi.next;
		hi.next = null;

		return list1;
	}
}