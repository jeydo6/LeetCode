using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _1189
    {
        public Int32 MaxNumberOfBalloons(String text)
        {
            String templateString = "balloon";

            Int32[] templateArray = new Int32[26];
            for (Int32 i = 0; i < templateString.Length; i++)
            {
                templateArray[templateString[i] - 'a']++;
            }

            Int32[] textArray = new Int32[26];
            for (Int32 i = 0; i < text.Length; i++)
            {
                textArray[text[i] - 'a']++;
            }

            Int32 result = Int32.MaxValue;
            for (Int32 i = 0; i < templateArray.Length; i++)
            {
                if (templateArray[i] > 0)
                {
                    Int32 count = textArray[i] / templateArray[i];
                    if (count < result)
                    {
                        result = count;
                    }
                }
            }
            return result;
        }
    }
}
