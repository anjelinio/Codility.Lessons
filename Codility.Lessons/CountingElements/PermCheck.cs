namespace Codility.Lessons.CountingElements
{
	// https://app.codility.com/demo/results/trainingH8CTMK-ZDA/

	using System.Linq;
	// you can also use other imports, for example:
	// using System.Collections.Generic;

	// you can write to stdout for debugging purposes, e.g.
	// Console.WriteLine("this is a debug message");

	class Solution
	{
		public int solution(int[] A)
		{
			// Implement your solution here
			return Enumerable.Range(1, A.Length)
				.Except(A)
				.Any() ? 0 : 1;
		}
	}
}
