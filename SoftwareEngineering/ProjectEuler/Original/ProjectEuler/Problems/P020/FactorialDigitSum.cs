using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler.Problems.P020
{
	class FactorialDigitSum
	{
		public void Run()
		{
			BigInteger number = Factorial(100);

			BigInteger sum = SumDigits(number);


			Console.WriteLine(sum);
		}

		//Use recursion to get factorial
		public BigInteger Factorial(BigInteger number)
		{
			BigInteger result = 0;
			if(number == 1)
			{
				return 1;
			}

			result = Factorial(number - 1) * number;
			return result;
		}

		public BigInteger SumDigits(BigInteger number)
		{
			BigInteger result = 0;

			while (number > 0)
			{
				result += (BigInteger)(number % 10);
				number /= 10;
			}

			return result;
		}
	}
}
