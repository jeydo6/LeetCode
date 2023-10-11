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

		public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
		{
			if (list1 == null)
			{
				return list2;
			}
			if (list2 == null)
			{
				return list1;
			}

			var temp = new ListNode(0);
			var current = temp;
			while (list1 != null && list2 != null)
			{
				if (list1.val <= list2.val)
				{
					current.next = list1;
					list1 = list1.next;
				}
				else
				{
					current.next = list2;
					list2 = list2.next;
				}
				current = current.next;
			}
			current.next = list1 ?? list2;
			return temp.next;
		}
	}
}
