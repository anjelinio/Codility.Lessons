namespace Codility.Lessons.TimeComplexity
{
	// https://app.codility.com/demo/results/trainingD5RV5E-RZX/

	using System.Linq;
	// you can also use other imports, for example:
	// using System.Collections.Generic;

	// you can write to stdout for debugging purposes, e.g.
	// Console.WriteLine("this is a debug message");

	class PermMissingElem
	{
		public int solution(int[] A)
		{
			// Implement your solution here
			var missing = Enumerable.Range(1, A.Length + 1)
				.Except(A)
				.SingleOrDefault();

			return missing;
		}
	}
}
