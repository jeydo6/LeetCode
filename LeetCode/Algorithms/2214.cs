using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2214
{
	public static long MinimumHealth(int[] damage, int armor)
	{
		var maxDamage = 0;
		var totalDamage = 0L;

		for (var i = 0; i < damage.Length; i++)
		{
			totalDamage += damage[i];
			if (damage[i] > maxDamage)
			{
				maxDamage = damage[i];
			}
		}

		return totalDamage - Math.Min(armor, maxDamage) + 1;
	}
}
