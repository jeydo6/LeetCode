using System;
using System.Text;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _535
	{
		public class Codec
		{
			private static readonly string baseUrl = "http://tinyurl.com/";

			public static string Encode(string longUrl)
			{
				var bytes = Encoding.UTF8.GetBytes(longUrl);
				return baseUrl + Convert.ToBase64String(bytes)
					.Replace("/", "-")
					.Replace("+", "_");
			}

			public static string Decode(string shortUrl)
			{
				var bytes = Convert.FromBase64String(
					shortUrl[baseUrl.Length..]
						.Replace("-", "/")
						.Replace("_", "+")
				);
				return Encoding.UTF8.GetString(bytes);
			}
		}
	}
}
