namespace LeetCode.Algorithms;

// EASY
internal class _21
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

	public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
	{
		var result = new ListNode();

		var prev = result;
		while (list1 != null && list2 != null)
		{
			if (list1.val <= list2.val)
			{
				prev.next = list1;
				list1 = list1.next;
			}
			else
			{
				prev.next = list2;
				list2 = list2.next;
			}

			prev = prev.next;
		}

		prev.next = list1 ?? list2;

		return result.next;
	}
}
