using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _1207
    {
        public Boolean UniqueOccurrences(Int32[] arr)
        {
            Dictionary<Int32, Int32> dict = new Dictionary<Int32, Int32>();

            foreach (Int32 item in arr)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }

            HashSet<Int32> hashSet = new HashSet<Int32>();
            foreach(Int32 item in dict.Values)
            {
                if (hashSet.Contains(item))
                {
                    return false;
                }

                hashSet.Add(item);
            }

            return true;
        }
    }
}
