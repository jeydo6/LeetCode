using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _1160
    {
        public Int32 CountCharacters(String[] words, String chars)
        {
            Int32 result = 0;

            Int32[] total = new Int32[26];
            foreach (Char c in chars)
            {
                Int32 index = c - 'a';
                total[index]++;
            }

            foreach (String w in words)
            {
                Boolean isValid = true;

                Int32[] local = new Int32[26];
                foreach (Char c in w)
                {
                    Int32 index = c - 'a';
                    local[index]++;
                    if (local[index] > total[index])
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    result += w.Length;
                }
            }

            return result;
        }
    }
}
