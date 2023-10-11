using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _71
{
	public static string SimplifyPath(string path)
	{
		var itemCount = 0;
		var components = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
		for (var i = 0; i < components.Length; i++)
		{
			switch (components[i])
			{
				case ".":
					break;
				case "..":
					if (itemCount > 0) itemCount--;
					break;
				default:
					components[itemCount++] = components[i];
					break;
			}
		}
		return "/" + string.Join('/', components, 0, itemCount);
	}
}
