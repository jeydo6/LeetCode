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
				_1945.GetLucky("zbax", 2)
			);
			Console.WriteLine(json);
		}
	}
}
