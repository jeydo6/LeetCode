﻿using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	internal class _929
	{
		public static int NumUniqueEmails(string[] emails)
		{
			var normalized = new HashSet<string>();
			for (var i = 0; i < emails.Length; i++)
			{
				var parts = emails[i].Split("@");
				var local = parts[0].Split("+");
				normalized.Add(local[0].Replace(".", "") + "@" + parts[1]);
			}
			return normalized.Count;
		}
	}
}
