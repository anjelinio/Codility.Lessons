namespace Codility.Lessons.TimeComplexity
{
	// https://app.codility.com/demo/results/trainingAU3YK2-94U/

	using System;
	using System.Collections.Generic;
	using System.Linq;
	// you can also use other imports, for example:
	// using System.Collections.Generic;

	// you can write to stdout for debugging purposes, e.g.
	// Console.WriteLine("this is a debug message");

	class TapeEquilibrium
	{
		public int solution(int[] A)
		{
			// Implement your solution here
			var diffs = new SortedSet<int>();

			var acc = 0;
			var total = A.Sum();

			for (var c = 0; c < A.Length - 1; c++)
			{
				acc += A[c];
				total -= A[c];

				diffs.Add(Math.Abs(acc - total));
			}

			return diffs.Min;
		}
	}
}
