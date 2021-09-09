using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P002
{
	class EvenFibonacci
	{
		public void Run()
		{

			Stopwatch sw = new Stopwatch();
			sw.Start();


			int first = 1;
			int second = 2;
			int limit = 4000000;
			int current = 0;

			List<int> numbers = new List<int>();

			numbers.Add(first);
			numbers.Add(second);

			while (current <= limit)
			{
				current = first + second;
								
				numbers.Add(current);

				first = second;
				second = current;
			}

			int sum = 0;
			foreach (int num in numbers)
			{
				if(num % 2 == 0)
				{
					sum += num;
				}
			}


			Console.WriteLine(sum);
			Console.WriteLine("--------");
			Console.WriteLine(sw.Elapsed);
			Console.WriteLine("--------");

		}
	}
}
