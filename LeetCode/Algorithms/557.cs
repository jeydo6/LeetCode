using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _557
    {
        public String ReverseWords(String s)
        {
            StringBuilder result = new StringBuilder(s.Length + 1);
            StringBuilder w = new StringBuilder();

            foreach (Char c in s)
            {
                if (c != ' ')
                {
                    w.Insert(0, c);
                }
                else
                {
                    result.Append(w);
                    result.Append(" ");

                    w.Clear();
                }
            }
            
            if (w.Length > 0)
            {
                result.Append(w);
                result.Append(" ");
            }

            return result
                .ToString()
                .TrimEnd();
        }
    }
}
