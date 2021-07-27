using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _884
    {
        public String[] UncommonFromSentences(String A, String B)
        {
            Dictionary<String, Int32> dict = new Dictionary<String, Int32>();

            String[] aWords = A.Split(' ');
            String[] bWords = B.Split(' ');

            foreach (String word in aWords)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 1;
                }
                else
                {
                    dict[word] = ++dict[word];
                }
            }

            foreach (String word in bWords)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 1;
                }
                else
                {
                    dict[word] = ++dict[word];
                }
            }

            ICollection<String> resultCollection = new List<String>();

            foreach (KeyValuePair<String, Int32> keyValue in dict)
            {
                if (keyValue.Value == 1)
                {
                    resultCollection.Add(keyValue.Key);
                }
            }

            String[] arr = new String[resultCollection.Count];
            resultCollection.CopyTo(arr, 0);

            return arr;
        }
    }
}
