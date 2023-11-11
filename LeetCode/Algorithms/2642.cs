using System;

namespace LeetCode.Algorithms;

// HARD
internal class _2642
{
    public class Graph
    {
        private readonly int[][] _matrix;

        public Graph(int n, int[][] edges)
        {
            _matrix = new int[n][];
            for (var i = 0; i < n; i++)
            {
                _matrix[i] = new int[n];
                for (var j = 0; j < n; j++)
                {
                    _matrix[i][j] = (int)1e9;
                }
            }

            for (var i = 0; i < edges.Length; i++)
            {
                _matrix[edges[i][0]][edges[i][1]] = edges[i][2];
            }

            for (var i = 0; i < n; i++)
            {
                _matrix[i][i] = 0;
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    for (var k = 0; k < n; k++)
                    {
                        _matrix[j][k] = Math.Min(
                            _matrix[j][k],
                            _matrix[j][i] + _matrix[i][k]
                        );
                    }
                }
            }
        }

        public void AddEdge(int[] edge)
        {
            var n = _matrix.Length;
            for (var j = 0; j < n; j++)
            {
                for (var k = 0; k < n; k++)
                {
                    _matrix[j][k] = Math.Min(
                        _matrix[j][k],
                        _matrix[j][edge[0]] +
                        _matrix[edge[1]][k] +
                        edge[2]
                    );
                }
            }
        }

        public int ShortestPath(int node1, int node2)
        {
            if (_matrix[node1][node2] == (int)1e9)
            {
                return -1;
            }

            return _matrix[node1][node2];
        }
    }
}