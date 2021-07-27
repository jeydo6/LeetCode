using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _500
    {
        public String[] FindWords(String[] words)
        {
            ICollection<String> resultCollection = new List<String>();

            Dictionary<Char, Int32> dict = new Dictionary<Char, Int32>
            {
                ['q'] = 0,
                ['w'] = 0,
                ['e'] = 0,
                ['r'] = 0,
                ['t'] = 0,
                ['y'] = 0,
                ['u'] = 0,
                ['i'] = 0,
                ['o'] = 0,
                ['p'] = 0,
                ['a'] = 1,
                ['s'] = 1,
                ['d'] = 1,
                ['f'] = 1,
                ['g'] = 1,
                ['h'] = 1,
                ['j'] = 1,
                ['k'] = 1,
                ['l'] = 1,
                ['z'] = 2,
                ['x'] = 2,
                ['c'] = 2,
                ['v'] = 2,
                ['b'] = 2,
                ['n'] = 2,
                ['m'] = 2
            };

            foreach(String word in words)
            {
                Boolean result = true;
                
                Int32 lineNumber = dict[Char.ToLower(word[0])];
                foreach (Char ch in word)
                {
                    if (dict[Char.ToLower(ch)] != lineNumber)
                    {
                        result = false;
                        break;
                    }
                }

                if (result)
                {
                    resultCollection.Add(word);
                }
            }

            String[] resultArray = new String[resultCollection.Count];
            resultCollection.CopyTo(resultArray, 0);

            return resultArray;
        }
    }
}
