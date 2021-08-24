namespace LeetCode.Algorithms
{
	class _537
	{
		public static string ComplexNumberMultiply(string num1, string num2)
		{
			var coefs1 = num1
				.Replace("i", "")
				.Split("+");
			var coefs2 = num2
				.Replace("i", "")
				.Split("+");

			var a = int.Parse(coefs1[0]);
			var b = int.Parse(coefs1[1]);
			var c = int.Parse(coefs2[0]);
			var d = int.Parse(coefs2[1]);

			return $"{a * c - b * d}+{a * d + b * c}i";
		}
	}
}
