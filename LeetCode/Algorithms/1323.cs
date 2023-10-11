using System;

namespace LeetCode.Algorithms
{
	class _1323
	{
		//public static int Maximum69Number(int number)
		//{
		//	var length = (int)Math.Ceiling(Math.Log10(number));
		//	var array = new int[length];
		//	for (var i = 0; i < length; i++)
		//	{
		//		array[i] = number % 10;
		//		number /= 10;
		//	}

		//	for (var i = 0; i < length; i++)
		//	{
		//		if (array[^(i + 1)] == 6)
		//		{
		//			array[^(i + 1)] = 9;
		//			break;
		//		}
		//	}

		//	var result = 0;
		//	var b = 1;
		//	for (var i = 0; i < length; i++)
		//	{
		//		result += array[i] * b;
		//		b *= 10;
		//	}
		//	return result;
		//}

		public static int Maximum69Number(int number)
		{
			var chars = number
				.ToString()
				.ToCharArray();

			for (var i = 0; i < chars.Length; i++)
			{
				if (chars[i] == '6')
				{
					chars[i] = '9';
					break;
				}
			}

			var result = new string(chars);
			return int.Parse(result);
		}
	}
}
