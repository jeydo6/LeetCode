using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _2391
{
    public static int GarbageCollection(string[] garbage, int[] travel)
    {
        var time = new int[3];

        for (var i = garbage.Length - 1; i >= 0; i--)
        {
            foreach (var ch in garbage[i])
            {
                var j = ch switch
                {
                    'P' => 0,
                    'M' => 1,
                    _ => 2
                };
                time[j] += 1;
            }

            var transfer = i > 0 ? travel[i - 1] : 0;

            for (var j = 0; j < 3; j++)
            {
                time[j] += time[j] != 0 ? transfer : 0;
            }
        }

        return time[0] + time[1] + time[2];
    }
}