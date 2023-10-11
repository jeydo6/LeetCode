using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _445
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

	public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
		var stack1 = new Stack<int>();
		var stack2 = new Stack<int>();

		while (l1 != null)
		{
			stack1.Push(l1.val);
			l1 = l1.next;
		}

		while (l2 != null)
		{
			stack2.Push(l2.val);
			l2 = l2.next;
		}

		var totalSum = 0;
		var carry = 0;
		var result = new ListNode();
		while (stack1.Count > 0 || stack2.Count > 0)
		{
			if (stack1.Count > 0)
			{
				totalSum += stack1.Pop();
			}

			if (stack2.Count > 0)
			{
				totalSum += stack2.Pop();
			}

			result.val = totalSum % 10;
			carry = totalSum / 10;
			var head = new ListNode(carry) { next = result };
			result = head;
			totalSum = carry;
		}

		return carry == 0 ? result.next : result;
	}
}