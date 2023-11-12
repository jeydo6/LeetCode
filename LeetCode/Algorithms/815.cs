using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _815
{
    public static int NumBusesToDestination(int[][] routes, int source, int target)
    {
        if (source == target)
        {
            return 0;
        }

        var list = new Dictionary<int, List<int>>();
        for (var r = 0; r < routes.Length; r++)
        {
            for (var i = 0; i < routes[r].Length; i++)
            {
                var stop = routes[r][i];
                list.TryAdd(stop, new List<int>());
                list[stop].Add(r);
            }
        }

        var queue = new Queue<int>();
        var visited = new HashSet<int>(routes.Length);
        for (var i = 0; i < list[source].Count; i++)
        {
            var route = list[source][i];
            queue.Enqueue(route);
            visited.Add(route);
        }

        var busCount = 1;
        while (queue.Count > 0)
        {
            var queueCount = queue.Count;
            for (var i = 0; i < queueCount; i++)
            {
                var route = queue.Dequeue();
                for (var j = 0; j < routes[route].Length; j++)
                {
                    var stop = routes[route][j];
                    if (stop == target)
                    {
                        return busCount;
                    }

                    for (var k = 0; k < list[stop].Count; k++)
                    {
                        var nextRoute = list[stop][k];
                        if (!visited.Contains(nextRoute))
                        {
                            visited.Add(nextRoute);
                            queue.Enqueue(nextRoute);
                        }
                    }
                }
            }
            busCount++;
        }

        return -1;
    }
}