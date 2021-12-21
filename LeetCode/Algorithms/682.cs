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
						{
							var value1 = points.Pop();
							var value2 = points.Pop();
							var value = value1 + value2;

							points.Push(value2);
							points.Push(value1);
							points.Push(value);

							break;
						}
					case "D":
						{
							var value1 = points.Pop();
							var value = value1 * 2;

							points.Push(value1);
							points.Push(value);

							break;
						}
					case "C":
						{
							points.Pop();

							break;
						}
					default:
						{
							if (int.TryParse(op, out var value))
							{
								points.Push(value);
							}

							break;
						}
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
