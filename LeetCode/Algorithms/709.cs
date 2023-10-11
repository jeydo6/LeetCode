using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _709
    {
        public String ToLowerCase(String str)
        {
            String result = "";

            foreach (Char c in str)
            {
                Int32 diff = 0;

                if (Char.IsUpper(c))
                {
                    diff = 'a' - 'A';
                }

                result += (Char)(c + diff);
            }

            return result;
        }
    }
}
