using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _1791
	{
		//public static int FindCenter(int[][] edges)
		//{
		//	var hashSet = new HashSet<int>();
		//	foreach (var edge in edges)
		//	{
		//		foreach (var node in edge)
		//		{
		//			if (hashSet.Contains(node))
		//			{
		//				return node;
		//			}
		//			else
		//			{
		//				hashSet.Add(node);
		//			}
		//		}
		//	}
		//	return 0;
		//}

		public static int FindCenter(int[][] edges)
		{
			return edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1] ?
				edges[0][0] :
				edges[0][1];
		}
	}
}
