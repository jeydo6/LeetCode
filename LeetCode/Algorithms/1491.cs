using System;

namespace LeetCode.Algorithms;

// EASY
internal class _1491
{
	public static double Average(int[] salary)
	{
		var minSalary = int.MaxValue;
		var maxSalary = int.MinValue;

		var sum = 0d;
		for (var i = 0; i < salary.Length; i++)
		{
			sum += salary[i];
			minSalary = Math.Min(minSalary, salary[i]);
			maxSalary = Math.Max(maxSalary, salary[i]);
		}

		return (sum - minSalary - maxSalary) / (salary.Length - 2);
	}
}
