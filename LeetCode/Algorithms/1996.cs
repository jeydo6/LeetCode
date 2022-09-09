namespace LeetCode.Algorithms;

// MEDIUM
internal class _1996
{
	public static int NumberOfWeakCharacters(int[][] properties)
	{
		var maxAttack = 0;
		for (var i = 0; i < properties.Length; i++)
		{
			var attack = properties[i][0];
			if (attack > maxAttack)
			{
				maxAttack = attack;
			}
		}

		var maxDefense = new int[maxAttack + 2];
		for (var i = 0; i < properties.Length; i++)
		{
			var attack = properties[i][0];
			var defense = properties[i][1];

			if (defense > maxDefense[attack])
			{
				maxDefense[attack] = defense;
			}
		}

		for (var i = maxAttack - 1; i >= 0; i--)
		{
			if (maxDefense[i + 1] > maxDefense[i])
			{
				maxDefense[i] = maxDefense[i + 1];
			}
		}

		var weakCharacters = 0;
		for (var i = 0; i < properties.Length; i++)
		{
			var attack = properties[i][0];
			var defense = properties[i][1];

			if (defense < maxDefense[attack + 1])
			{
				weakCharacters++;
			}
		}

		return weakCharacters;
	}
}
