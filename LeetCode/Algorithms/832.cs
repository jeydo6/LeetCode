using System;

public class _832
{
    public Int32[][] FlipAndInvertImage(Int32[][] A)
    {
        foreach (Int32[] row in A)
        {
            Array.Reverse(row);
        }

        foreach (Int32[] row in A)
        {
            for (Int32 i = 0; i < row.Length; i++)
            {
                row[i] = (row[i] + 1) % 2;
            }
        }
        return A;
    }
}