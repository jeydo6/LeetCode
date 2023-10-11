using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _344
    {
        public void ReverseString(Char[] s)
        {
            Int32 length = s.Length / 2;
            for (Int32 i = 0; i < length; i++)
            {
                Char temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
        }
    }
}
