using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _476
    {
        public Int32 FindComplement(Int32 num)
        {
            Int32 bitsCount = (Int32)(Math.Floor(Math.Log(num) / Math.Log(2))) + 1;

            Int32 baseNum = ((1 << bitsCount) - 1);

            return baseNum ^ num;
        }
    }
}
