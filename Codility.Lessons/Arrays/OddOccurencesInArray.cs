namespace Codility.Lessons.Arrays
{
	// https://app.codility.com/demo/results/trainingFANY4Y-HPM/

	using System.Collections.Generic;
	using System.Linq;
	// you can also use other imports, for example:
	// using System.Collections.Generic;

	// you can write to stdout for debugging purposes, e.g.
	// Console.WriteLine("this is a debug message");

	class OddOccurencesInArray
	{
		public int solution(int[] A)
		{
			// Implement your solution here
			if (!A?.Any() ?? false)
				return -1;

			var counts = new Dictionary<int, int>();
			foreach (var num in A)
			{
				if (counts.ContainsKey(num))
					counts[num] = counts[num] + 1;
				else
					counts[num] = 1;

				if (counts[num] == 2)
					counts.Remove(num);
			}

			var unpaired = counts.Where(kvp => 1 == kvp.Value).FirstOrDefault();

			return 0 != unpaired.Value
			? unpaired.Key
			: -1;
		}
	}
}
