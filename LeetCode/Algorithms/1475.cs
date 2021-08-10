using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _1475
	{
		public static int[] FinalPrices(int[] prices)
		{
			var stack = new Stack<int>();
			for (var i = 0; i < prices.Length; i++)
			{
				while (stack.Count > 0 && prices[stack.Peek()] >= prices[i])
				{
					prices[stack.Pop()] -= prices[i];
				}
				stack.Push(i);
			}
			return prices;
		}
	}
}
