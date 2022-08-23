using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _234
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

		public static bool IsPalindrome(ListNode head)
		{
			var stack = new Stack<ListNode>();
			
			var node = head;
			while (node != null)
			{
				stack.Push(node);
				node = node.next;
			}

			while (stack.Count > 0)
			{
				var current = stack.Pop();
				if (head.val != current.val)
				{
					return false;
				}

				head = head.next;
			}

			return true;
		}
	}
}
