namespace Codility.Lessons.CountingElements
{
	// https://app.codility.com/demo/results/trainingK88G4R-4DQ/

	using System.Linq;
	// you can also use other imports, for example:
	// using System.Collections.Generic;

	// you can write to stdout for debugging purposes, e.g.
	// Console.WriteLine("this is a debug message");

	class MissingInteger
	{
		public int solution(int[] A)
		{
			// Implement your solution here
			if (!A?.Any() ?? false) return 1;

			var sorted = A.Where(c => 0 < c).OrderBy(c => c).Distinct().ToArray();
			var lookFor = 1;
			var found = false;

			do
			{
				if (lookFor > sorted.Length || sorted[lookFor - 1] != lookFor)
					found = true;
				else
					lookFor++;
			}
			while (!found);

			return lookFor;
		}
	}
}
