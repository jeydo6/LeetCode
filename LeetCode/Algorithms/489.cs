using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _489
	{
#pragma warning disable IDE1006 // Naming Styles
		public interface Robot
		{
			// Returns true if the cell in front is open and robot moves into the cell.
			// Returns false if the cell in front is blocked and robot stays in the current cell.
			public bool Move();

			// Robot will stay in the same cell after calling turnLeft/turnRight.
			// Each turn will be 90 degrees.
			public void TurnLeft();
			public void TurnRight();

			// Clean the current cell.
			public void Clean();
		}
#pragma warning restore IDE1006 // Naming Styles

		public class Solution
		{
			private static readonly int[][] _directions = new int[4][]
			{
				new int[2] { -1, 0 },
				new int[2] { 0, 1 },
				new int[2] { 1, 0 },
				new int[2] { 0, -1 }
			};

			private readonly ISet<(int Row, int Column)> _visited = new HashSet<(int Row, int Column)>();

			private Robot _robot;

			public void CleanRoom(Robot robot)
			{
				_robot = robot;
				Backtrack(0, 0, 0);
			}

			private void Backtrack(int row, int col, int d)
			{
				_visited.Add((row, col));
				_robot.Clean();
				for (var i = 0; i < _directions.Length; i++)
				{
					var newD = (d + i) % 4;
					var newRow = row + _directions[newD][0];
					var newCol = col + _directions[newD][1];

					if (!_visited.Contains((newRow, newCol)) && _robot.Move())
					{
						Backtrack(newRow, newCol, newD);
						GoBack();
					}
					_robot.TurnRight();
				}
			}

			private void GoBack()
			{
				_robot.TurnRight();
				_robot.TurnRight();
				_robot.Move();
				_robot.TurnRight();
				_robot.TurnRight();
			}
		}
	}
}
