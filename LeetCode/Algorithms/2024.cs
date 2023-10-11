using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2024
{
	public static int MaxConsecutiveAnswers(string answerKey, int k)
	{
		var result = k;
		var counts = new Dictionary<char, int>();
		for (var i = 0; i < k; i++)
		{
			counts.TryAdd(answerKey[i], 0);
			counts[answerKey[i]]++;
		}
        
		var left = 0;
		for (var right = k; right < answerKey.Length; right++)
		{
			counts.TryAdd(answerKey[right], 0);
			counts[answerKey[right]]++;

			while (Math.Min(
				counts.ContainsKey('T') ? counts['T'] : 0,
				counts.ContainsKey('F') ? counts['F'] : 0) > k)
			{

				counts[answerKey[left]]--;
				left++;
			}
            
			result = Math.Max(result, right - left + 1);
		}
                    
		return result;
	}
}