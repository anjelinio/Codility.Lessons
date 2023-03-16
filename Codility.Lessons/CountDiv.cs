// https://app.codility.com/demo/results/training92SAUQ-2MC/

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class CountDiv
{
	public int solution(int A, int B, int K)
	{
		// Implement your solution here
		var divisor = 0;

		for (var c = A; c <= B && divisor == 0; c++)
			if (0 == c % K)
				divisor = c;

		return 0 < divisor
			? (B - divisor) / K + 1
			: 0;
	}
}



/*

minimal
A = B in {0,1}, K = 11✘WRONG ANSWER
got 1 expected 0
▶extreme_ifempty
A = 10, B = 10, K in {5,7,20}✘WRONG ANSWER
got 2 expected 0
▶extreme_endpoints
verify handling of range endpoints, multiple runs✘WRONG ANSWER
got 7 expected 8
expand allPerformance tests
▶big_values
A = 100, B=123M+, K=2✔OK
▶big_values2
A = 101, B = 123M+, K = 10K✔OK
▶big_values3
A = 0, B = MAXINT, K in {1,MAXINT}✘WRONG ANSWER
got 2000000000 expected 2000000001
▶big_values4
A, B, K in {1,MAXINT}✘WRONG ANSWER
got 2 expected 1

*/