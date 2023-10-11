﻿using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _496
	{
		public static int[] NextGreaterElement(int[] nums1, int[] nums2)
		{
			var dict = new Dictionary<int, int>();

			var stack = new Stack<int>();
			for (var i = nums2.Length - 1; i >= 0; i--)
			{
				while (stack.Count > 0 && stack.Peek() < nums2[i])
				{
					stack.Pop();
				}
				dict[nums2[i]] = stack.Count == 0 ? -1 : stack.Peek();
				stack.Push(nums2[i]);
			}

			var result = new int[nums1.Length];
			for (var i = 0; i < nums1.Length; i++)
			{
				result[i] = dict[nums1[i]];
			}
			return result;
		}
	}
}
