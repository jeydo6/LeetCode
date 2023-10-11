﻿using System;
using System.Text;

namespace LeetCode.Algorithms;

// EASY
internal class _1768
{
	public static string MergeAlternately(string word1, string word2)
	{
		var sb = new StringBuilder(word1.Length + word2.Length);
		for (var i = 0; i < Math.Max(word1.Length, word2.Length); i++)
		{
			if (i < word1.Length)
			{
				sb.Append(word1[i]);
			}
			if (i < word2.Length)
			{
				sb.Append(word2[i]);
			}
		}
		return sb.ToString();
	}
}
