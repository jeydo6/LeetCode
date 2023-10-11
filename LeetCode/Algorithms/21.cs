namespace LeetCode.Algorithms
{
	class _21
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

		public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
		{
			if (l1 == null)
			{
				return l2;
			}
			if (l2 == null)
			{
				return l1;
			}

			var temp = new ListNode(0);
			var current = temp;
			while (l1 != null && l2 != null)
			{
				if (l1.val <= l2.val)
				{
					current.next = l1;
					l1 = l1.next;
				}
				else
				{
					current.next = l2;
					l2 = l2.next;
				}
				current = current.next;
			}
			current.next = l1 ?? l2;
			return temp.next;
		}
	}
}
