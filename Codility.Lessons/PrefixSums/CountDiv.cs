namespace Codility.Lessons.PrefixSums
{
	// https://app.codility.com/demo/results/trainingEAYDN3-H6C/
	// https://app.codility.com/demo/results/training92SAUQ-2MC/

	using System;
	// you can also use other imports, for example:
	// using System.Collections.Generic;

	// you can write to stdout for debugging purposes, e.g.
	// Console.WriteLine("this is a debug message");

	class CountDiv
	{
		public int solution(int A, int B, int K)
		{
			// Implement your solution here
			var divisor = -1;

			for (var c = A; c <= B && divisor == -1; c++)
				if (0 == c % K)
					divisor = c;

			return -1 < divisor
				? (B - divisor) / K + 1
				: 0;
		}
	}
}