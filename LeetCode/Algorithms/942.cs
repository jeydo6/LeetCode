using System;

public class _942
{
    public Int32[] DiStringMatch(String S)
    {
        S = S.ToLower();
        Int32 length = S.Length;
        Int32 min = 0;
        Int32 max = length;

        Int32[] resultArray = new Int32[length + 1];

        for (Int32 i = 0; i < length; i++)
        {
            Char c = S[i];
            if (c == 'i')
            {
                resultArray[i] = min++;
            }

            if (c == 'd')
            {
                resultArray[i] = max--;
            }
        }

        resultArray[length] = min;

        return resultArray;
    }
}