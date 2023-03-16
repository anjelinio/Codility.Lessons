namespace Codility.Lessons
{
	// https://app.codility.com/demo/results/trainingVU3BZX-5Z2/

	// you can also use other imports, for example:
	// using System.Collections.Generic;

	// you can write to stdout for debugging purposes, e.g.
	// Console.WriteLine("this is a debug message");

	class CountingCars
	{
		public int solution(int[] A)
		{
			// Implement your solution here
			var zero = 0;
			var one = 0;

			var pairs = 0;
			var limit = 1000000000;

			for (var c = A.Length - 1; c >= 0; c--)
			{
				if (A[c] == 1)
				{
					one++;
				}
				else if (A[c] == 0)
				{
					zero++;
					pairs += one;
				}

				if (limit < pairs)
					return -1;
			}

			return pairs;
		}
	}
}
