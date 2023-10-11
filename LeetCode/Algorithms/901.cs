using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _901
{
	public class StockSpanner
	{
		private readonly Stack<int[]> _stack;

		public StockSpanner()
		{
			_stack = new Stack<int[]>();
		}

		public int Next(int price)
		{
			var result = 1;
			while (_stack.Count > 0 && _stack.Peek()[0] <= price)
			{
				result += _stack.Pop()[1];
			}

			_stack.Push(new int[] { price, result });

			return result;
		}
	}
}
