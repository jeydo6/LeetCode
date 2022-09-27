using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _838
{
	public static string PushDominoes(string dominoes)
	{
		var forces = new int[dominoes.Length];

		var force1 = 0;
		for (var i = 0; i < forces.Length; i++)
		{
			if (dominoes[i] == 'R')
			{
				force1 = forces.Length;
			}
			else if (dominoes[i] == 'L')
			{
				force1 = 0;
			}
			else
			{
				force1 = Math.Max(force1 - 1, 0);
			}

			forces[i] += force1;
		}

		var force2 = 0;
		for (var i = forces.Length - 1; i >= 0; i--)
		{
			if (dominoes[i] == 'L')
			{
				force2 = forces.Length;
			}
			else if (dominoes[i] == 'R')
			{
				force2 = 0;
			}
			else
			{
				force2 = Math.Max(force2 - 1, 0);
			}

			forces[i] -= force2;
		}

		var result = new char[forces.Length];
		for (var i = 0; i < forces.Length; i++)
		{
			result[i] = forces[i] > 0 ? 'R' : forces[i] < 0 ? 'L' : '.';
		}
		return new string(result);
	}
}
