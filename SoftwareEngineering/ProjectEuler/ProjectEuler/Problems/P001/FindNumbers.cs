using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P001
{
	class FindNumbers
	{
		public void Run()
		{
			//Find the sum of all multiples of 3 and 5 below 1000.

			//List<int> numbers = new List<int>();

			int sum = 0;
			for (int i = 0; i < 1000; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					//numbers.Add(i);
					sum += i;
				}
			}

			Console.WriteLine(sum);

		}


	}
}
