using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _804
    {
        public Int32 UniqueMorseRepresentations(String[] words)
        {
            Dictionary<Char, String> letterToMorse = new Dictionary<Char, String>
            {
                ['a'] = ".-",
                ['b'] = "-...",
                ['c'] = "-.-.",
                ['d'] = "-..",
                ['e'] = ".",
                ['f'] = "..-.",
                ['g'] = "--.",
                ['h'] = "....",
                ['i'] = "..",
                ['j'] = ".---",
                ['k'] = "-.-",
                ['l'] = ".-..",
                ['m'] = "--",
                ['n'] = "-.",
                ['o'] = "---",
                ['p'] = ".--.",
                ['q'] = "--.-",
                ['r'] = ".-.",
                ['s'] = "...",
                ['t'] = "-",
                ['u'] = "..-",
                ['v'] = "...-",
                ['w'] = ".--",
                ['x'] = "-..-",
                ['y'] = "-.--",
                ['z'] = "--.."
            };

            ICollection<String> morseWords = new List<String>();
            foreach (String word in words)
            {
                String morseWord = "";
                foreach (Char letter in word)
                {
                    Char lowerLetter = Char.ToLower(letter);
                    if (letterToMorse.ContainsKey(lowerLetter))
                    {
                        morseWord += letterToMorse[lowerLetter];
                    }
                }

                if (!morseWords.Contains(morseWord))
                {
                    morseWords.Add(morseWord);
                }
            }

            Int32 result = morseWords.Count;

            return result;
        }
    }
}
