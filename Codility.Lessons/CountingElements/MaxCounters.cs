namespace Codility.Lessons.CountingElements
{
	// https://app.codility.com/demo/results/training6B2HZW-UU5/

	// you can also use other imports, for example:
	// using System.Collections.Generic;

	// you can write to stdout for debugging purposes, e.g.
	// Console.WriteLine("this is a debug message");

	class MaxCounters
	{
		public int[] solution(int N, int[] A)
		{
			// Implement your solution here
			var counters = new int[N];
			var max = 0;

			foreach (var op in A)
			{
				if (1 <= op && op <= N)
				{
					var value = ++counters[op - 1];
					if (value > max) max = value;
				}
				else if (op == N + 1)
					for (var c = 0; c < counters.Length; c++)
						counters[c] = max;
			}

			return counters;
		}
	}
}
