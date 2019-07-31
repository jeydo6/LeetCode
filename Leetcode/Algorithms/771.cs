using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _771
    {
        public Int32 NumJewelsInStones(String J, String S)
        {
            Int32 result = 0;

            foreach (Char s in S)
            {
                if (J.Contains(s))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
