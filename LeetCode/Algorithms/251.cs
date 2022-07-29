using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	internal class _251
	{
		public class Vector2D
		{
			private readonly List<int> _numbers = new List<int>();

			private int _position = 0;

			public Vector2D(int[][] vec)
			{
				foreach (var inner in vec)
				{
					_numbers.AddRange(inner);
				}
			}

			public int Next()
			{
				if (!HasNext())
				{
					throw new IndexOutOfRangeException();
				}

				return _numbers[_position++];
			}

			public bool HasNext()
			{
				return _position < _numbers.Count;
			}
		}
	}
}
