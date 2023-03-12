namespace Codility.Lessons.TimeComplexity
{
	// https://app.codility.com/demo/results/trainingMM3TKB-4KS/

	using System;
	// you can also use other imports, for example:
	// using System.Collections.Generic;

	// you can write to stdout for debugging purposes, e.g.
	// Console.WriteLine("this is a debug message");

	class Solution
	{
		public int solution(int X, int Y, int D)
		{
			// Implement your solution here
			int rem;
			var steps = Math.DivRem((Y - X), D, out rem);

			return steps + ((rem >= 1) ? 1 : 0);
		}
	}
}
