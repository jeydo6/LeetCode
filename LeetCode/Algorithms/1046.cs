using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _1046
    {
        public Int32 LastStoneWeight(Int32[] stones)
        {
            if (stones.Length == 1)
            {
                return stones[0];
            }

            while (true)
            {
                Array.Sort(
                    stones,
                    new Comparison<Int32>((a, b) =>
                    {
                        return b - a;
                    })
                );

                if (stones[1] == 0)
                {
                    break;
                }

                stones[0] -= stones[1];
                stones[1] = 0;
            }

            return stones[0];
        }
    }
}
