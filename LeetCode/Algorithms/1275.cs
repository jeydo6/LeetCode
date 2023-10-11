namespace LeetCode.Algorithms
{
	internal class _1275
	{
		public static string Tictactoe(int[][] moves)
		{
			var a = new int[8];
			var b = new int[8];

			for (var i = 0; i < moves.Length; i++)
			{
				var r = moves[i][0];
				var c = moves[i][1];

				var p = i % 2 == 0 ? a : b;
				p[r]++;
				p[c + 3]++;
				if (r == c)
				{
					p[6]++;
				}
				if (r == 2 - c)
				{
					p[7]++;
				}
			}

			for (var i = 0; i < 8; i++)
			{
				if (a[i] == 3)
				{
					return "A";
				}
				if (b[i] == 3)
				{
					return "B";
				}
			}

			return moves.Length == 9 ? "Draw" : "Pending";
		}
	}
}
