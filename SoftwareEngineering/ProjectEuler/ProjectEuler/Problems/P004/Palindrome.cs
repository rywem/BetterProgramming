using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P004
{
	class Palindrome
	{
		public void Run()
		{
			/*
			int number = 9119;
			int reversedNumber = Reversed(number);


			*/

			int highest = 0;

			for (int i = 100; i < 1000; i++)
			{
				for (int ii = 100; ii < 1000; ii++)
				{
					int total = i * ii;
					int reversedTotal = Reversed(total);

					bool status = Compare(total, reversedTotal);
					
					if(status)
					{
						if(total > highest)
						{
							highest = total;
							
						}						
					}
				}
			}

			Console.WriteLine(highest);


			/*

			bool status = Compare(number, reversedNumber);

			if(status)
			{
				Console.WriteLine("equal");
			}
			else
			{
				Console.WriteLine("Not Equal");
			}
			*/
		}

		public int Reversed(int number)
		{
			string numberString = number.ToString();
			char[] charArray = numberString.ToCharArray();
			Array.Reverse(charArray);
			string reversedString = new string(charArray);
			
			


			int reversedNumber = (int)int.Parse(reversedString);

			return reversedNumber;

		}

		public bool Compare(int numberOne, int numberTwo)
		{			
			if(numberOne == numberTwo)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
