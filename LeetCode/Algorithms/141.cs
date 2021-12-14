namespace LeetCode.Algorithms
{
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
			var walker = head;
			var runner = head;
			while (runner.next != null && runner.next.next != null)
			{
				walker = walker.next;
				runner = runner.next.next;
				if (walker == runner)
				{
					return true;
				}
			}
			return false;
		}
	}
}
