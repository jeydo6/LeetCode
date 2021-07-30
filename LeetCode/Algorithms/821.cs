using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _821
    {
        public Int32[] ShortestToChar(String S, Char C)
        {
            Int32[] arr = new Int32[S.Length];
            for (Int32 i = 0; i < S.Length; i++)
            {
                arr[i] = 10000;
            }

            Int32 distance = 10000;
            for (Int32 i = 0; i < S.Length; i++)
            {
                if (S[i] == C)
                {
                    distance = 0;
                }
                else
                {
                    distance++;
                }

                arr[i] = Math.Min(arr[i], distance);
            }

            distance = 10000;
            for (Int32 i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == C)
                {
                    distance = 0;
                }
                else
                {
                    distance++;
                }

                arr[i] = Math.Min(arr[i], distance);
            }

            return arr;
        }
    }
}
