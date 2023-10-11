using LeetCode.Algorithms;
using Newtonsoft.Json;
using System;

namespace LeetCode
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				_1480.RunningSum(new int[] { 1, 2, 3, 4 })
			);
			Console.WriteLine(json);
		}
	}
}
