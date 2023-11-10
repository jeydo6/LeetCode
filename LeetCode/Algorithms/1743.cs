using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1743
{
    public static int[] RestoreArray(int[][] adjacentPairs)
    {
        var graph = new Dictionary<int, List<int>>();
        for (var i = 0; i < adjacentPairs.Length; i++)
        {
            var x = adjacentPairs[i][0];
            var y = adjacentPairs[i][1];

            if (!graph.ContainsKey(x))
            {
                graph[x] = new List<int>();
            }
            if (!graph.ContainsKey(y))
            {
                graph[y] = new List<int>();
            }
            
            graph[x].Add(y);
            graph[y].Add(x);
        }
        
        var root = 0;
        foreach (var num in graph.Keys)
        {
            if (graph[num].Count == 1)
            {
                root = num;
                break;
            }
        }
        

        int[] result = new int[graph.Count];
        result[0] = root;

        var current = root;
        var previous = int.MaxValue;
        var j = 1;
        while (j < result.Length)
        {
            foreach (var neighbor in graph[current])
            {
                if (neighbor != previous)
                {
                    result[j++] = neighbor;
                    previous = current;
                    current = neighbor;
                    break;
                }
            }
        }

        return result;
    }
}