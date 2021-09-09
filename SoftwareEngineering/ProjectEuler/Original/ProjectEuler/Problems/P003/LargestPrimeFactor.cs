using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P003
{
	class LargestPrimeFactor
	{
		public void Run()
		{

			Stopwatch sw = new Stopwatch();
			sw.Start();

			long startNumber = 600851475143;

			List<long> primeNumbers = new List<long>();

			for (long i = startNumber/2 + 1; i >= 2; i--)
			{
				if(startNumber % i == 0)
				{
					if(IsPrime(i))
					{
						primeNumbers.Add(i);
						Console.WriteLine("Adding: {0}", i);
					}
				}
			}

			long highest = 0;
			foreach (long item in primeNumbers)
			{
				if(item > highest)
				{
					highest = item;
				}
			}

			Console.WriteLine(highest);
			Console.WriteLine("--------");
			Console.WriteLine(sw.Elapsed);
			Console.WriteLine("--------");

		}

		//Determine if a number is a prime number
		public bool IsPrime(long number)
		{
			bool isPrimeNumber = true;
			long counter = number - 1;

			if (number == 2)
			{
				return true;
			}
			else
			{
				do
				{

					if (number % counter == 0)
					{

						isPrimeNumber = false;
					}
					counter--;
				} while (isPrimeNumber && counter != 1);
			}

			return isPrimeNumber;

		}
	}
}
