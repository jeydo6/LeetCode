using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _463
    {
        public Int32 IslandPerimeter(Int32[][] grid)
        {
            Int32 islands = 0;
            Int32 neighbours = 0;

            for (Int32 i = 0; i < grid.Length; i++)
            {
                for (Int32 j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        islands++;
                        if (i < grid.Length - 1 && grid[i + 1][j] == 1)
                        {
                            neighbours++;
                        }
                        if (j < grid[i].Length - 1 && grid[i][j + 1] == 1)
                        {
                            neighbours++;
                        }
                    }
                }
            }

            Int32 result = islands * 4 - neighbours * 2;

            return result;
        }
    }
}
