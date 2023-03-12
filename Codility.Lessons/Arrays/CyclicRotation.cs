namespace Codility.Lessons.Arrays
{
	// https://app.codility.com/demo/results/trainingA6NFG7-ANC/

	using System.Linq;
	// you can also use other imports, for example:
	// using System.Collections.Generic;

	// you can write to stdout for debugging purposes, e.g.
	// Console.WriteLine("this is a debug message");

	class CyclicRotation
	{
		public int[] solution(int[] A, int K)
		{
			// Implement your solution here
			if (!A?.Any() ?? false)
				return A;

			var retVal = A;
			for (var c = 0; c < K; c++)
			{
				retVal = (new int[] { retVal[retVal.Length - 1] })
					.Concat(retVal.Take(retVal.Length - 1))
					.ToArray();
			}

			return retVal;
		}
	}
}
