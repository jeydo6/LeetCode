using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _1496
{
    private static readonly IDictionary<char, (int X, int Y)> _directions = new Dictionary<char, (int X, int Y)>
    {
        ['N'] = (0, 1),
        ['S'] = (0, -1),
        ['W'] = (-1, 0),
        ['E'] = (1, 0),
    };

    public static bool IsPathCrossing(string path)
    {
        var visited = new HashSet<(int X, int Y)>
        {
            (0, 0)
        };

        var x = 0;
        var y = 0;
        for (var i = 0; i < path.Length; i++)
        {
            var (dx, dy) = _directions[path[i]];
            x += dx;
            y += dy;

            var pair = (x, y);
            if (visited.Contains(pair))
            {
                return true;
            }

            visited.Add(pair);
        }

        return false;
    }
}