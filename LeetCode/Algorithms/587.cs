namespace LeetCode.Algorithms
{
	// HARD
	class _587
	{
		public static int[][] OuterTrees(int[][] trees)
		{
			Array.Sort(trees, (p, q) => q[0] - p[0] == 0 ? q[1] - p[1] : q[0] - p[0]);

			var stack = new Stack<int[]>();
			for (var i = 0; i < trees.Length; i++)
			{
				while (stack.Count >= 2 && Orientation(stack.ElementAt(1), stack.Peek(), trees[i]) > 0)
				{
					stack.Pop();
				}
				stack.Push(trees[i]);
			}

			stack.Pop();

			for (var i = trees.Length - 1; i >= 0; i--)
			{
				while (stack.Count >= 2 && Orientation(stack.ElementAt(1), stack.Peek(), trees[i]) > 0)
				{
					stack.Pop();
				}
				stack.Push(trees[i]);
			}

			var hashSet = new HashSet<int[]>(stack);
			return hashSet.ToArray();
		}

		private static int Orientation(int[] p, int[] q, int[] r)
		{
			return (q[1] - p[1]) * (r[0] - q[0]) - (q[0] - p[0]) * (r[1] - q[1]);
		}
	}
}
