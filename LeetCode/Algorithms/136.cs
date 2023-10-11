using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _136
    {
        public Int32 SingleNumber(Int32[] nums)
        {
            //HashSet<Int32> hashSet = new HashSet<Int32>();

            //foreach (Int32 num in nums)
            //{
            //    if (!hashSet.Contains(num))
            //    {
            //        hashSet.Add(num);
            //    }
            //    else
            //    {
            //        hashSet.Remove(num);
            //    }
            //}

            //Int32[] arr = new Int32[hashSet.Count];
            //hashSet.CopyTo(arr);

            //return arr[0];

            Int32 result = 0;

            foreach (Int32 num in nums)
            {
                result ^= num;
            }

            return result;
        }
    }
}
