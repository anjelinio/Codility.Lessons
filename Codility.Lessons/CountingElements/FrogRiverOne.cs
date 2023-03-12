namespace Codility.Lessons.CountingElements
{
	// https://app.codility.com/demo/results/trainingKZQ4DP-G77/

	using System.Collections.Generic;
	// you can also use other imports, for example:
	// using System.Collections.Generic;

	// you can write to stdout for debugging purposes, e.g.
	// Console.WriteLine("this is a debug message");

	class FrogRiverOne
	{
		public int solution(int X, int[] A)
		{
			// Implement your solution here
			var indexedTimes = new Dictionary<int, int>();

			for (var second = 0; second < A.Length; second++)
			{
				var position = A[second];
				if (!indexedTimes.ContainsKey(position))
					indexedTimes[position] = second;
				else
				{
					if (indexedTimes[position] > second)
						indexedTimes[position] = second;
				}
			}

			var max = 0;
			for (var c = 1; c <= X; c++)
			{
				if (!indexedTimes.ContainsKey(c))
					return -1;

				var sec = indexedTimes[c];
				max = max >= sec ? max : sec;
			}

			return max;
		}
	}
}
