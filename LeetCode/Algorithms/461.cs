using System;

public class _461
{
    public Int32 HammingDistance(Int32 x, Int32 y)
    {
        Int32 result = 0;

        while (x > 0 || y > 0)
        {
            if (x % 2 != y % 2)
            {
                result++;
            }

            x = x / 2;
            y = y / 2;
        }

        return result;
    }
}