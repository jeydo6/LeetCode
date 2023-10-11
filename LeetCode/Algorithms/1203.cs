using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _1203
{
    public static int[] SortItems(int n, int m, int[] group, IList<IList<int>> beforeItems)
    {
        var groupId = m;
        for (var i = 0; i < n; i++)
        {
            if (group[i] == -1)
            {
                group[i] = groupId;
                groupId++;
            }
        }

        var itemGraph = new Dictionary<int, IList<int>>();
        var itemIndegree = new int[n];
        for (var i = 0; i < n; i++)
        {
            itemGraph[i] = new List<int>();
        }

        var groupGraph = new Dictionary<int, IList<int>>();
        var groupIndegree = new int[groupId];
        for (var i = 0; i < groupId; i++)
        {
            groupGraph[i] = new List<int>();
        }
        
        for (var current = 0; current < n; current++)
        {
            foreach (var previous in beforeItems[current])
            {
                itemGraph[previous].Add(current);
                itemIndegree[current]++;

                if (group[current] != group[previous])
                {
                    groupGraph[group[previous]].Add(group[current]);
                    groupIndegree[group[current]]++;
                }
            }
        }

        var itemOrder = TopologicalSort(itemGraph, itemIndegree);
        var groupOrder = TopologicalSort(groupGraph, groupIndegree);
        
        if (itemOrder.Count == 0 || groupOrder.Count == 0)
        {
            return Array.Empty<int>();
        }

        var orderedGroups = new Dictionary<int, IList<int>>();
        foreach (var item in itemOrder)
        {
            if(!orderedGroups.ContainsKey(group[item]))
            {
                orderedGroups[group[item]] = new List<int>();
            }
            orderedGroups[group[item]].Add(item);
        }

        var result = new List<int>();
        foreach (var groupIndex in groupOrder)
        {
            if (orderedGroups.ContainsKey(groupIndex))
            {
                result.AddRange(orderedGroups[groupIndex]);
            }
        }

        return result.ToArray();
    }

    private static IReadOnlyCollection<int> TopologicalSort(IDictionary<int, IList<int>> graph, int[] indegree)
    {
        var stack = new Stack<int>();
        foreach (var key in graph.Keys)
        {
            if (indegree[key] == 0)
            {
                stack.Push(key);
            }
        }

        var visited = new List<int>();
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            visited.Add(current);

            foreach (var previous in graph[current])
            {
                indegree[previous]--;
                if (indegree[previous] == 0)
                {
                    stack.Push(previous);
                }
            }
        }

        return visited.Count == graph.Count ? visited : Array.Empty<int>();
    }
}