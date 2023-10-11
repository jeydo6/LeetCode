using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _229
{
	public static IList<int> MajorityElement(int[] nums)
	{
		if (nums.Length == 0)
		{
			return new List<int>();
		}

		var num1 = -1;
		var num2 = -1;
		var count1 = 0;
		var count2 = 0;

		for (var i = 0; i < nums.Length; i++)
		{
			if (nums[i] == num1)
			{
				count1++;
			}
			else if (nums[i] == num2)
			{
				count2++;
			}
			else if (count1 == 0)
			{
				num1 = nums[i];
				count1 = 1;
			}
			else if (count2 == 0)
			{
				num2 = nums[i];
				count2 = 1;
			}
			else
			{
				count1--;
				count2--;
			}
		}

		count1 = 0;
		count2 = 0;
		for (var i = 0; i < nums.Length; i++)
		{
			if (nums[i] == num1)
			{
				count1++;
			}
			else if (nums[i] == num2)
			{
				count2++;
			}
		}

		var result = new List<int>();
		if (count1 > nums.Length / 3)
		{
			result.Add(num1);
		}

		if (count2 > nums.Length / 3)
		{
			result.Add(num2);
		}

		return result;
	}
}
