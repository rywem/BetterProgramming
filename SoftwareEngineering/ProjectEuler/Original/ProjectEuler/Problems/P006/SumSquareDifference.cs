using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P006
{
	class SumSquareDifference
	{
		public void Run()
		{
			int sumOfTheSquares = 0;
			for (int i = 1; i <= 100; i++)
			{
				int squared = i * i;
				sumOfTheSquares += squared;
			}

			Console.WriteLine(sumOfTheSquares);

			int sum = 0;

			for (int i = 1; i <= 100; i++)
			{
				sum += i;
			}
			Console.WriteLine(sum);

			int squareOfTheSum = sum * sum;

			int final = squareOfTheSum - sumOfTheSquares;

			Console.WriteLine(final);
		}
	}
}
