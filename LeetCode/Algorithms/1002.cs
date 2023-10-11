using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Algorithms
{
    public class _1002
    {
        public IList<String> CommonChars(String[] A)
        {

            //if (A.Length == 0)
            //{
            //    return new List<String>();
            //}

            #region 260ms
            //IList<String> resultList = new List<String>();

            //Char[] resultChars = A[0].ToCharArray();

            //for (Int32 i = 1; i < A.Length; i++)
            //{
            //    Char[] aChars = A[i].ToCharArray();

            //    for (Int32 j = 0; j < resultChars.Length; j++)
            //    {
            //        if (resultChars[j] != '\0')
            //        {
            //            Int32 findIndex = Array.FindIndex(aChars, c => c == resultChars[j]);
            //            if (findIndex > -1)
            //            {
            //                aChars[findIndex] = '\0';
            //            }
            //            else
            //            {
            //                resultChars[j] = '\0';
            //            }
            //        }
            //    }
            //}

            //for (Int32 i = 0; i < resultChars.Length; i++)
            //{
            //    if (resultChars[i] != '\0')
            //    {
            //        resultList.Add(resultChars[i].ToString());
            //    }
            //}
            #endregion
            #region 256ms
            IList<String> resultList = new List<String>();

            Byte alphabetLength = 26;

            Byte[] totalCount = new Byte[alphabetLength];
            for (Byte i = 0; i < alphabetLength; i++)
            {
                totalCount[i] = Byte.MaxValue;
            }

            foreach (String str in A)
            {
                Byte[] strCount = new Byte[alphabetLength];
                foreach (Char c in str.ToCharArray())
                {
                    strCount[c - 'a']++;
                }

                for (Byte i = 0; i < alphabetLength; i++)
                {
                    totalCount[i] = Math.Min(strCount[i], totalCount[i]);
                }
            }

            for (Byte i = 0; i < alphabetLength; i++)
            {
                while (totalCount[i]-- > 0)
                {
                    resultList.Add("" + (Char)(i + 'a'));
                }
            }

            return resultList;
            #endregion
        }
    }
}
