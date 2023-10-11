using System;

public class _905
{
    public Int32[] SortArrayByParity(Int32[] A)
    {
        Array.Sort(A, (m, n) =>
        {
            return m % 2 - n % 2;
        });

        return A;
    }
}