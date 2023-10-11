using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _1078
    {
        public String[] FindOcurrences(String text, String first, String second)
        {
            ICollection<String> resultCollection = new List<String>();

            String[] words = text.Split(' ');

            for (Int32 i = 0; i < words.Length - 2; i++)
            {
                if (words[i] == first && words[i + 1] == second)
                {
                    resultCollection.Add(words[i + 2]);
                }
            }

            return resultCollection.ToArray();
        }
    }
}
