namespace LeetCode.Algorithms
{
	public class _430
	{
		public class Node
		{
			public int val;
			public Node prev;
			public Node next;
			public Node child;
		}

		public static Node Flatten(Node head)
		{
			if (head == null)
			{
				return null;
			}

			var node = head;
			while (node != null)
			{
				if (node.child == null)
				{
					node = node.next;
					continue;
				}

				var temp = node.child;
				while (temp.next != null)
				{
					temp = temp.next;
				}

				temp.next = node.next;
				if (node.next != null)
				{
					node.next.prev = temp;
				}

				node.next = node.child;
				node.child.prev = node;
				node.child = null;
			}

			return head;
		}
	}
}