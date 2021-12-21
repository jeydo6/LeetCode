﻿using System.Collections.Generic;

namespace Leetcode.Algorithms
{
	internal class _500
	{
		public static string[] FindWords(string[] words)
		{
			var result = new List<string>();

			var dict = new Dictionary<char, int>
			{
				['q'] = 0,
				['w'] = 0,
				['e'] = 0,
				['r'] = 0,
				['t'] = 0,
				['y'] = 0,
				['u'] = 0,
				['i'] = 0,
				['o'] = 0,
				['p'] = 0,
				['a'] = 1,
				['s'] = 1,
				['d'] = 1,
				['f'] = 1,
				['g'] = 1,
				['h'] = 1,
				['j'] = 1,
				['k'] = 1,
				['l'] = 1,
				['z'] = 2,
				['x'] = 2,
				['c'] = 2,
				['v'] = 2,
				['b'] = 2,
				['n'] = 2,
				['m'] = 2
			};

			foreach (var word in words)
			{
				var isResult = true;
				foreach (var ch in word)
				{
					if (dict[char.ToLower(ch)] != dict[char.ToLower(word[0])])
					{
						isResult = false;
						break;
					}
				}
				if (isResult)
				{
					result.Add(word);
				}
			}

			return result.ToArray();
		}
	}
}
