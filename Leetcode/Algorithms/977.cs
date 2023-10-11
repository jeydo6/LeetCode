using System;
using System.Linq;

public class _977
{
    public Int32[] SortedSquares(Int32[] A)
    {
        for (Int32 i = 0; i < A.Length; i++)
        {
            A[i] = A[i] * A[i];
        }

        Array.Sort(A);

        return A;
    }
}