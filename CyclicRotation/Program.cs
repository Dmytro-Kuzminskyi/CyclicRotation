using System;

namespace CyclicRotation
{
	class Program
	{
		static void Main(string[] args)
		{
			Solution s = new Solution();
			Console.Write("Enter N: ");
			int N = int.Parse(Console.ReadLine());
			Console.Write("Enter K: ");
			int K = int.Parse(Console.ReadLine());
			int[] A = new int[N];
			for (int i = 0; i < N; i++)
			{
				Console.Write("Enter {0} element: ", i + 1);
				A[i] = int.Parse(Console.ReadLine());
			}
			Console.Write("The result is [{0}]", string.Join(" ",s.solution(A, K)));
			Console.ReadKey();
		}
	}
}
