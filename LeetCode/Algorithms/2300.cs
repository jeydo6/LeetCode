using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2300
{
	public static int[] SuccessfulPairs(int[] spells, int[] potions, long success)
	{
		var sortedSpells = new int[spells.Length][];
		for (var i = 0; i < sortedSpells.Length; i++)
		{
			sortedSpells[i] = new int[] { spells[i], i };
		}

		Array.Sort(sortedSpells, (a, b) => a[0] - b[0]);
		Array.Sort(potions);

		var result = new int[spells.Length];
		var potionIndex = potions.Length - 1;
		for (var i = 0; i < sortedSpells.Length; i++)
		{
			var spell = sortedSpells[i][0];
			var index = sortedSpells[i][1];

			while (potionIndex >= 0 && (long)spell * potions[potionIndex] >= success)
			{
				potionIndex--;
			}
			result[index] = potions.Length - (potionIndex + 1);
		}

		return result;
	}
}
