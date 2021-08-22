namespace LeetCode.Algorithms
{
	class _850
	{
		//public static int RectangleArea(int[][] rectangles)
		//{
		//	var list = new List<int[]>();
		//	foreach (var rectangle in rectangles)
		//	{
		//		AddRectangle(list, rectangle, 0);
		//	}

		//	var result = 0L;
		//	foreach (var item in list)
		//	{
		//		result = (result + (long)(item[2] - item[0]) * (item[3] - item[1])) % 1000000007L;
		//	}

		//	return (int)(result % 1000000007L);
		//}

		//public static void AddRectangle(List<int[]> list, int[] currentItem, int start)
		//{
		//	if (start >= list.Count)
		//	{
		//		list.Add(currentItem);
		//		return;
		//	}

		//	var startItem = list[start];
		//	if (currentItem[2] <= startItem[0] || currentItem[3] <= startItem[1] || currentItem[0] >= startItem[2] || currentItem[1] >= startItem[3])
		//	{
		//		AddRectangle(list, currentItem, start + 1);
		//		return;
		//	}

		//	if (currentItem[0] < startItem[0])
		//	{
		//		AddRectangle(list, new int[] { currentItem[0], currentItem[1], startItem[0], currentItem[3] }, start + 1);
		//	}

		//	if (currentItem[2] > startItem[2])
		//	{
		//		AddRectangle(list, new int[] { startItem[2], currentItem[1], currentItem[2], currentItem[3] }, start + 1);
		//	}

		//	if (currentItem[1] < startItem[1])
		//	{
		//		AddRectangle(list, new int[] { Math.Max(startItem[0], currentItem[0]), currentItem[1], Math.Min(startItem[2], currentItem[2]), startItem[1] }, start + 1);
		//	}

		//	if (currentItem[3] > startItem[3])
		//	{
		//		AddRectangle(list, new int[] { Math.Max(startItem[0], currentItem[0]), startItem[3], Math.Min(startItem[2], currentItem[2]), currentItem[3] }, start + 1);
		//	}
		//}

		public static int RectangleArea(int[][] rectangles)
		{
			rectangles = rectangles
				.OrderBy(u => u[0])
				.ToArray();

			var result = 0L;

			for (var i = 0; i < rectangles.Length; i++)
			{
				var current = rectangles[i];

				var stack = new Stack<int[]>();
				var next = new Stack<int[]>();

				stack.Push(current);

				for (var j = i - 1; j >= 0; j--)
				{
					var prev = rectangles[j];

					while (stack.Count > 0)
					{
						var rectangle = stack.Pop();

						if (prev[2] <= rectangle[0] || prev[1] >= rectangle[3] || prev[3] <= rectangle[1])
						{
							next.Push(rectangle);
							continue;
						}
						if (prev[2] >= rectangle[2] && prev[1] <= rectangle[1] && prev[3] >= rectangle[3])
						{
							continue;
						}

						if (prev[2] >= rectangle[2])
						{

							if (prev[1] >= rectangle[1])
							{
								if (prev[3] >= rectangle[3])
								{
									next.Push(new[] { rectangle[0], rectangle[1], rectangle[2], prev[1] });
								}
								else
								{
									next.Push(new[] { rectangle[0], rectangle[1], rectangle[2], prev[1] });
									next.Push(new[] { rectangle[0], prev[3], rectangle[2], rectangle[3] });
								}
							}
							else
							{
								next.Push(new[] { rectangle[0], prev[3], rectangle[2], rectangle[3] });
							}
						}
						else
						{
							if (prev[1] <= rectangle[1] && prev[3] >= rectangle[3])
							{
								next.Push(new[] { prev[2], rectangle[1], rectangle[2], rectangle[3] });
							}
							else if (prev[1] >= rectangle[1])
							{
								if (prev[3] >= rectangle[3])
								{
									next.Push(new[] { rectangle[0], rectangle[1], prev[2], prev[1] });
									next.Push(new[] { prev[2], rectangle[1], rectangle[2], rectangle[3] });
								}
								else
								{
									next.Push(new[] { rectangle[0], rectangle[1], prev[2], prev[1] });
									next.Push(new[] { prev[2], rectangle[1], rectangle[2], rectangle[3] });
									next.Push(new[] { rectangle[0], prev[3], prev[2], rectangle[3] });
								}
							}
							else
							{
								next.Push(new[] { rectangle[0], prev[3], prev[2], rectangle[3] });
								next.Push(new[] { prev[2], rectangle[1], rectangle[2], rectangle[3] });
							}
						}

					}
					var temp = stack;
					stack = next;
					next = temp;
				}

				while (stack.Count > 0)
				{
					var area = stack.Pop();
					result += Math.Abs((long)(area[2] - area[0]) * (area[3] - area[1]));
				}

			}

			return (int)(result % 1_000_000_007L);
		}
	}
}
