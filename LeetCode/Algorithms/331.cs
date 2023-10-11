namespace LeetCode.Algorithms
{
	class _331
	{
		public static bool IsValidSerialization(string preorder)
		{
			var diff = 1;
			var nodes = preorder.Split(",");
			foreach (var node in nodes)
			{
				if (diff-- < 0)
				{
					return false;
				}

				if (node != "#")
				{
					diff += 2;
				}
			}
			return diff == 0;
		}
	}
}
