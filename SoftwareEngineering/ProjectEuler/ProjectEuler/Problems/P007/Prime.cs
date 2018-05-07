using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P007
{
	class Prime
	{
		public void Run()
		{
			int currentNumber = 0;
			int primeCount = 0;

			while(primeCount < 10001)
			{
				bool checkPrime = IsPrime(currentNumber);

				if(checkPrime)
				{
					Console.WriteLine("Prime Found: " + currentNumber);
					primeCount++;
					Console.WriteLine("primeCount: " + primeCount );
				}
				currentNumber++;
			}

			//Console.WriteLine(primeCount + ": " + currentNumber);

		}

		//Returns true if prime, returns false if not prime.
		public bool IsPrime(int number)
		{

			bool isPrimeNumber = true;

			int counter = number - 1;

			if(number == 0 || number == 1)
			{
				return isPrimeNumber = false;
			}
			else if(number == 2)
            {
				return isPrimeNumber = true;
			}
			else
			{
				do
				{
					//Console.WriteLine(number + " / " + counter);
					if(number % counter == 0)
					{
						//Console.WriteLine(number + " is divisible by " + counter + " - changing isPrimeNumber to FALSE");
						isPrimeNumber = false;
					}
					counter--;
				} while (isPrimeNumber && counter != 1);
			}

			return isPrimeNumber;
		}

	}
}
