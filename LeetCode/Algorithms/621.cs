using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _621
{
	public static int LeastInterval(char[] tasks, int n)
	{
		var frequencies = new int[26];
		var maxCount = 0;

		for (var i = 0; i < tasks.Length; i++)
		{
			frequencies[tasks[i] - 'A']++;
			maxCount = Math.Max(maxCount, frequencies[tasks[i] - 'A']);
		}

		var time = (maxCount - 1) * (n + 1);
		for (var i = 0; i < frequencies.Length; i++)
		{
			if (frequencies[i] == maxCount)
			{
				time++;
			}
		}

		return Math.Max(tasks.Length, time);
	}
}