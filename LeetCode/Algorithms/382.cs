using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _382
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

	public class Solution
	{
		private static readonly Random _random = new Random();

		private readonly ListNode _head;

		public Solution(ListNode head)
		{
			_head = head;
		}

		public int GetRandom()
		{
			var i = 1;
			var c = _head;
			var result = c.val;
			while (c.next != null)
			{
				c = c.next;
				if (_random.Next(i + 1) == i)
				{
					result = c.val;
				}
				i++;
			}
			return result;
		}
	}
}
