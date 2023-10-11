namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _2
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

		public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			var dummy = new ListNode(0);
			var p = l1;
			var q = l2;
			var current = dummy;
			var carry = 0;
			while (p != null || q != null)
			{
				var x = (p != null) ? p.val : 0;
				var y = (q != null) ? q.val : 0;
				var sum = carry + x + y;
				carry = sum / 10;
				current.next = new ListNode(sum % 10);
				current = current.next;
				if (p != null) p = p.next;
				if (q != null) q = q.next;
			}
			if (carry > 0)
			{
				current.next = new ListNode(carry);
			}
			return dummy.next;
		}
	}
}
