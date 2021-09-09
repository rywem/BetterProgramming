using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P010
{
	class SumOfPrimes
	{
		public void Run()
		{
			Console.WriteLine("Find the sum of prime numbers below a number.");
			Console.WriteLine("Below what number?");
			int input = Int32.Parse(Console.ReadLine());

			long total = 0;
			int currentNumber = 0;

			for (currentNumber = 0; currentNumber < input; currentNumber++)
			{
				//Console.WriteLine(currentNumber);
				bool isPrimeNumber = IsPrime(currentNumber);

				if (isPrimeNumber)
				{					
					total += currentNumber;
					Console.WriteLine("Prime Found, Adding {0} to make = {1}", currentNumber, total);
				}

				Console.WriteLine(currentNumber);	
			}

			Console.WriteLine(total);

		}

		//Returns true if prime, returns false if not prime.
		public bool IsPrime(int number)
		{
			bool isPrimeNumber = true;
			int counter = number - 1;
			if (number == 0 || number == 1)
			{
				return isPrimeNumber = false;
			}
			else if (number == 2)
			{
				return isPrimeNumber = true;
			}
			else if(number % 2 == 0)
			{
				return isPrimeNumber = false;
			}

			else if (number == 3)
			{
				return isPrimeNumber = true;
			}
			else if (number % 3 == 0)
			{
				return isPrimeNumber = false;
			}

			else if (number == 5)
			{
				return isPrimeNumber = true;
			}

			else if (number % 5 == 0)
			{
				return isPrimeNumber = false;
			}

			else if (number == 7)
			{
				return isPrimeNumber = true;
			}

			else if (number % 7 == 0)
			{
				return isPrimeNumber = false;
			}

			else if (number % 9 == 0)
			{
				return isPrimeNumber = false;
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
