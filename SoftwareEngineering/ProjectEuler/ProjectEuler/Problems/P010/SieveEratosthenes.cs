using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P010
{
	class SieveEratosthenes
	{
		int upperLimit = 2000000;

		public void Run()
		{

			Stopwatch s = new Stopwatch();
			s.Start();

			//Create a list of numbers up to 2m
			List<int> numbers = Numbers();
			

			for (int current = 2; current < upperLimit; current++)
			{

				int match = 0;
				match = numbers.FirstOrDefault(item => item == current);

				if (match == 0)
				{
					//Do nothing. Move on.
				}
				else
				{

					Console.WriteLine(match);

					bool isPrime = IsPrime(match);

					if (isPrime)
					{
						//If true, remove its multiples from the list
						for (int i = 2; match * i <= upperLimit; i++)
						{
							int multiple = 0;
							multiple = numbers.FirstOrDefault(item => item == match * i);
							if (multiple == 0)
							{

							}
							else
							{
								if(multiple % 10000 == 0)
								{
									Console.WriteLine(multiple);
								}
								
								numbers.Remove(multiple);
							}
						}
					}
					else
					{
						//If false, remove it from the list... it shouldn't ever hit this block but I added it to be safe
						numbers.Remove(match);
					}
				}

				Console.WriteLine(s.Elapsed);			
			}

			//Add up the remaining values in the list

			long total = 0;

			foreach(int number in numbers)
			{
				total += number;
			}

			Console.WriteLine("--------");
			Console.WriteLine(total);
			
			Console.WriteLine(s.Elapsed);
		}

		//Determine if a number is a prime number
		public bool IsPrime(int number)
		{
			bool isPrimeNumber = true;
			int counter = number - 1;

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


		//Return a list of number up to 2,000,000
		public List<int> Numbers()
		{
			List<int> numbers = new List<int>();

			for(int i = 2; i <= upperLimit; i++)
			{
				numbers.Add(i);
			}

			return numbers;
		}
	}


}
