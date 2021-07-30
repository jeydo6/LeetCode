using System;
using System.Collections.Generic;

public class _728
{
    public IList<Int32> SelfDividingNumbers(Int32 left, Int32 right)
    {
        IList<Int32> resultList = new List<Int32>();

        while (left <= right)
        {
            Boolean isSelfDivide = true;
            Int32 number = left;

            while (number > 0)
            {
                Int32 divider = number % 10;

                if (divider == 0 || left % divider != 0)
                {
                    isSelfDivide = false;
                    break;
                }

                number /= 10;
            }

            if (isSelfDivide)
            {
                resultList.Add(left);
            }

            left++;
        }

        return resultList;
    }
}