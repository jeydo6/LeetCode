using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _1122
    {
        //    public Int32[] RelativeSortArray(Int32[] arr1, Int32[] arr2)
        //    {
        //        Dictionary<Int32, Int32> dict2 = new Dictionary<Int32, Int32>();
        //        for (Int32 i = 0; i < arr2.Length; i++)
        //        {
        //            dict2[arr2[i]] = i - 1000;
        //        }

        //        Array.Sort(arr1, (item1, item2) =>
        //        {
        //            Int32 val1 = dict2.ContainsKey(item1) ? dict2[item1] : item1;
        //            Int32 val2 = dict2.ContainsKey(item2) ? dict2[item2] : item2;

        //            return val1.CompareTo(val2);
        //        });

        //        return arr1;
        //    }
        //}
        public Int32[] RelativeSortArray(Int32[] arr1, Int32[] arr2)
        {
            Dictionary<Int32, Int32> dict2 = new Dictionary<Int32, Int32>();
            for (Int32 i = 0; i < arr2.Length; i++)
            {
                dict2[arr2[i]] = i;
            }

            Array.Sort(arr1, (item1, item2) =>
            {
                if (dict2.ContainsKey(item1) && dict2.ContainsKey(item2))
                {
                    return dict2[item1].CompareTo(dict2[item2]);
                }
                else if (dict2.ContainsKey(item1))
                {
                    return -1;
                }
                else if (dict2.ContainsKey(item2))
                {
                    return 1;
                }
                else
                {
                    return item1.CompareTo(item2);
                }
            });

            return arr1;
        }
    }
}
