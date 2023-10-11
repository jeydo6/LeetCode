using System.Collections.Generic;

namespace LeetCode.Algorithms;

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

	public static bool IsPalindromeO1(ListNode head)
	{
		if (head == null)
		{
			return true;
		}

		var mid = GetListMiddle(head);
		var second = ReverseList(mid.next);

		var p1 = head;
		var p2 = second;

		var result = true;
		while (result && p2 != null)
		{
			if (p1.val != p2.val)
			{
				result = false;
			}

			p1 = p1.next;
			p2 = p2.next;
		}

		mid.next = ReverseList(second);

		return result;
	}

	private static ListNode GetListMiddle(ListNode head)
	{
		var slow = head;
		var fast = head;

		while (fast.next != null && fast.next.next != null)
		{
			fast = fast.next.next;
			slow = slow.next;
		}

		return slow;
	}

	private static ListNode ReverseList(ListNode head)
	{
		var previous = default(ListNode);
		var current = head;
		while (current != null)
		{
			var next = current.next;
			current.next = previous;
			previous = current;
			current = next;
		}

		return previous;
	}
}
