using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _501
{
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;

		public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}
	}

	public static int[] FindMode(TreeNode root)
	{
		var result = new List<int>();

		var maxStreak = 0;
		var currentStreak = 0;
		var currentNum = 0;
		var current = root;
		while (current != null)
		{
			if (current.left != null)
			{
				var friend = current.left;
				while (friend.right != null)
				{
					friend = friend.right;
				}

				friend.right = current;

				var left = current.left;
				current.left = null;
				current = left;
			}
			else
			{
				var val = current.val;
				if (val == currentNum)
				{
					currentStreak++;
				}
				else
				{
					currentStreak = 1;
					currentNum = val;
				}

				if (currentStreak > maxStreak)
				{
					result = new List<int>();
					maxStreak = currentStreak;
				}

				if (currentStreak == maxStreak)
				{
					result.Add(val);
				}

				current = current.right;
			}
		}

		return result.ToArray();
	}
}