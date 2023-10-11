using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _138
	{
		public class Node
		{
			public int val;
			public Node next;
			public Node random;

			public Node(int _val)
			{
				val = _val;
				next = null;
				random = null;
			}
		}

		public static Node CopyRandomList(Node head)
		{
			if (head == null)
			{
				return null;
			}

			var ptr = head;
			while (ptr != null)
			{
				var newNode = new Node(ptr.val)
				{
					next = ptr.next
				};

				ptr.next = newNode;
				ptr = newNode.next;
			}

			ptr = head;
			while (ptr != null)
			{
				ptr.next.random = ptr.random?.next;
				ptr = ptr.next.next;
			}

			var ptrOldList = head;
			var ptrNewList = head.next;
			var prev = head.next;
			while (ptrOldList != null)
			{
				ptrOldList.next = ptrOldList.next.next;
				ptrNewList.next = ptrNewList.next?.next;
				ptrOldList = ptrOldList.next;
				ptrNewList = ptrNewList.next;
			}
			return prev;
		}
	}
}
