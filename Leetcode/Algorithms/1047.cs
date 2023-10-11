using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _1047
    {
        public String RemoveDuplicates(String S)
        {
            while (S.Length > 1)
            {
                StringBuilder sb = new StringBuilder(S);

                Int32 i = 0;
                Int32 j = 0;

                while (i < S.Length - 1)
                {
                    if (S[i] == S[i + 1])
                    {
                        sb.Remove(j, 2);

                        i += 2;
                    }
                    else
                    {
                        i++;
                        j++;
                    }
                }

                if (sb.Length != S.Length)
                {
                    S = sb.ToString();
                }
                else
                {
                    break;
                }
            }

            return S;
        }
    }
}
