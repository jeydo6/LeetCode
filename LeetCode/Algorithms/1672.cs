using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
	class _1672
	{
		public static int MaximumWealth(int[][] accounts)
		{
			return accounts
				.Select(a => a.Sum())
				.OrderByDescending(s => s)
				.First();
		}
	}
}
