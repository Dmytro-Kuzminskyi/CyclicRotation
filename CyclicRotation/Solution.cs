namespace CyclicRotation
{
	class Solution
	{
		public int[] solution(int[] A, int K)
		{
			if (A.Length > 0)
			{
				int lastPosition;
				while (K > 0)
				{
					lastPosition = A[A.Length - 1];
					for(int i = A.Length - 2; i >= 0; i--)
					{
						A[i + 1] = A[i];
					}
					A[0] = lastPosition;
					K--;
				}
				return A;
			}
			else return A;
		}
	}
}
