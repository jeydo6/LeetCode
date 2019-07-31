using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class _1021
{
    // public String RemoveOuterParentheses(String S)
    // {
    //     String result = "";

    //     Int32 pCount = 0;
    //     String primitive = "";
    //     for (Int32 i = 0; i < S.Length; i++)
    //     {
    //         primitive += S[i];

    //         if (S[i] == '(')
    //         {
    //             pCount++;
    //         }
    //         else if (S[i] == ')')
    //         {
    //             pCount--;
    //         }

    //         if (pCount == 0 && primitive.Length > 0)
    //         {
    //             result += primitive.Substring(1, primitive.Length - 2);
    //             primitive = "";
    //         }
    //     }

    //     return result;
    // }

    public String RemoveOuterParentheses(String S)
    {
        Stack<Char> stack = new Stack<Char>();
        StringBuilder result = new StringBuilder();

		if (String.IsNullOrEmpty(S))
            return "";
        
        foreach(Char c in S)
        {
            if (c == '(')    
            {   
                if (stack.Count() != 0)
                {
                    result.Append(c);
                }
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count() != 1)
                {
                    result.Append(c);
                }
                stack.Pop();
            }
        }
        
        return result.ToString();
    }
}