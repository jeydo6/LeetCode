using System;


public class _944
{
    public Int32 MinDeletionSize(String[] A)
    {
        if (A.Length < 2)
        {
            return 0;
        }

        Int32 result = 0;
        
        Int32 strSize = A[0].Length;

        for (Int32 j = 0; j < strSize; j++)
        {
            for (Int32 i = 1; i < A.Length; i++)
            {
                if (A[i - 1][j] > A[i][j])
                {
                    result++;
                    break;
                }
            }
        }

        return result;
    }
}
