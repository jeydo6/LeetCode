using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _1217
    {
        public Int32 MinCostToMoveChips(Int32[] chips)
        {
            Int32 odd = 0;
            Int32 even = 0;

            foreach (Int32 chip in chips)
            {
                if (chip % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            return Math.Min(odd, even);
        }
    }
}
