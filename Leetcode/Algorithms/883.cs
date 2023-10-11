using System;

public class _883
{
    public Int32 ProjectionArea(Int32[][] grid)
    {
        Int32 result = 0;

        Int32 mx = -1;
        Int32 my = -1;

        for (Int32 i = 0; i < grid.Length; i++)
        {
            for (Int32 j = 0; j < grid[i].Length; j++)
            {
                if (grid[j][i] > mx)
                {
                    mx = grid[j][i];
                }

                if (grid[i][j] > my)
                {
                    my = grid[i][j];
                }

                result += (grid[i][j] == 0 ? 0 : 1);
            }

            result += (mx + my);

            mx = -1;
            my = -1;
        }
        return result;
    }
}