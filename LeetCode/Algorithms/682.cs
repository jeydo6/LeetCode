using System.Collections.Generic;

namespace Leetcode.Algorithms
{
	// EASY
	internal class _682
	{
		public static int CalPoints(string[] ops)
		{
			var points = new Stack<int>();
			points.Push(0);
			points.Push(0);

			foreach (var op in ops)
			{
				switch (op)
				{
					case "+":
						var top = points.Pop();
						var newTop = top + points.Peek();

						points.Push(top);
						points.Push(newTop);
						break;
					case "D":
						points.Push(2 * points.Peek());
						break;
					case "C":
						points.Pop();
						break;
					default:
						points.Push(int.Parse(op));
						break;
				}
			}

			var sum = 0;
			while (points.Count > 0)
			{
				sum += points.Pop();
			}
			return sum;
		}
	}
}
