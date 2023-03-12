namespace Codility.Lessons.Iterations
{
	using System;
	using System.Linq;
	// you can also use other imports, for example:
	// using System.Collections.Generic;

	// you can write to stdout for debugging purposes, e.g.
	// Console.WriteLine("this is a debug message");

	class BinaryGap
	{
		public int solution(int N)
		{
			// Implement your solution here
			var binary = Convert.ToString(N, 2);

			binary = binary.Substring(
					binary.IndexOf('1') + 1,
					binary.LastIndexOf('1')
				);

			var zeros = binary.Split(new char[] { '1' }, StringSplitOptions.RemoveEmptyEntries)
				.OrderByDescending(s => s.Length);

			return zeros.FirstOrDefault()?.Length ?? 0;
		}
	}
}
