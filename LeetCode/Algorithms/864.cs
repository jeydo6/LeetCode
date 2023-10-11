using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _864
{
	private static readonly int[][] _directions =
	{
		new[] { 0, 1 },
		new[] { 1, 0 },
		new[] { -1, 0 },
		new[] { 0, -1 }
	};

	public static int ShortestPathAllKeys(string[] grid)
	{
		var n = grid.Length;
		var m = grid[0].Length;
		var queue = new Queue<int[]>();

		var seen = new Dictionary<int, ISet<(int, int)>>();

		var keySet = new HashSet<char>();
		var lockSet = new HashSet<char>();

		var allKeys = 0;
		var startR = -1;
		var startC = -1;
		for (var i = 0; i < n; i++)
		{
			for (var j = 0; j < m; j++)
			{
				var cell = grid[i][j];
				if (cell is >= 'a' and <= 'f')
				{
					allKeys += 1 << (cell - 'a');
					keySet.Add(cell);
				}

				if (cell is >= 'A' and <= 'F')
				{
					lockSet.Add(cell);
				}

				if (cell == '@')
				{
					startR = i;
					startC = j;
				}
			}
		}
		
		queue.Enqueue(new[] { startR, startC, 0, 0 });
		seen[0] = new HashSet<(int, int)> { (startR, startC) };
		while (queue.Count > 0)
		{
			var current = queue.Dequeue();
			var currentR = current[0];
			var currentC = current[1];
			var currentKeys = current[2];
			var distance = current[3];
			foreach (var direction in _directions)
			{
				var newR = currentR + direction[0];
				var newC = currentC + direction[1];
				if (newR >= 0 && newR < n &&
				    newC >= 0 && newC < m &&
				    grid[newR][newC] != '#')
				{
					var cell = grid[newR][newC];
					if (keySet.Contains(cell))
					{
						if (((1 << (cell - 'a')) & currentKeys) != 0)
						{
							continue;
						}
						
						var newKeys = currentKeys | (1 << (cell - 'a'));
						if (newKeys == allKeys)
						{
							return distance + 1;
						}

						seen.TryAdd(newKeys, new HashSet<(int, int)>());
						seen[newKeys].Add((newR, newC));
						queue.Enqueue(new[] { newR, newC, newKeys, distance + 1 });
					}
					
					if (lockSet.Contains(cell) && (currentKeys & (1 << (cell - 'A'))) == 0)
					{
						continue;
					}
					else if (!seen[currentKeys].Contains((newR, newC)))
					{
						seen[currentKeys].Add((newR, newC));
						queue.Enqueue(new[] { newR, newC, currentKeys, distance + 1 });
					}
				}
			}
		}

		return -1;
	}
}