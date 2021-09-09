using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P012
{
	class TriangleNumber
	{
		public void Run()
		{
			Console.WriteLine("Have over how many divisors?");
			int input = Int32.Parse(Console.ReadLine());

			int currentNumber = 6000;
			int count = 0;
			//Run the loop while true
			bool run = true;


			while(run)
			{
				currentNumber++;
				count = 0;
				int total = CalculateTriangle(currentNumber);
				count = CountDivisors(total);

				Console.WriteLine("Divisors: {0}, Number: {1}, Total: {2}", count, currentNumber, total);

				if (count >= input)
				{
					run = false;
					break;
				}				
			}
			Console.WriteLine("----------------------------------");
			Console.WriteLine("FINAL - Divisors: {0}, Total: {1}", count, currentNumber);

		}

		//Calculates the top level triangle number.
		public int CalculateTriangle(int startNumber)
		{
			int total = 0;

			for (int i = startNumber; i > 0; i--)
			{
				total += i;
			}
			return total;
		}

		//Count divisors
		public int CountDivisors(int triangleNumber)
		{
			int count = 0;

			for (int i = triangleNumber; i > 0; i--)
			{
				if(triangleNumber % i == 0)
				{
					count++;
				}
			}
			return count;
		}
	}
}
