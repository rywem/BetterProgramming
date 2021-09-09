using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler.Problems.P016
{
	class PowerDigitSum
	{
		public void Run()
		{
			int result = 0;

			BigInteger number = BigInteger.Pow(2, 1000);

			Console.WriteLine(number);

			while(number > 0)
			{
				result += (int)(number % 10);
				number /= 10;
			}

			Console.WriteLine(result);

		}

	
	}
}
