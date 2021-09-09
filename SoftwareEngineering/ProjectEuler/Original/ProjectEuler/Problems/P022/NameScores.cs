using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P022
{
	class NameScores
	{
		public void Run()
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();

			string filename = @"F:\ProjectEuler\P022\names.txt";
			string[] names = ReadInput(filename);

			string[] namesSorted = BubbleSort(names);
			int sumResult = 0;

			for (int i = 0; i < namesSorted.Length; i++)
			{
				sumResult += (i + 1) * Sum(namesSorted[i]);
			}

			Console.WriteLine("----------");
			Console.WriteLine("Total: {0}", sumResult);
			Console.WriteLine("----------");
			Console.WriteLine(sw.Elapsed);
			Console.WriteLine("----------");

		}

		public int Sum(string name)
		{
			int result = 0;

			for(int i = 0; i < name.Length; i++)
			{
				result += Convert.ToInt32(name[i] - 64);
			}

			return result;
		}

		public string[] BubbleSort(string[] strings)
		{
			//Initialize a variable to determine if there was a change.
			bool changed = true;

			while(changed)
			{
				//Set changed to false.
				changed = false;

				for(int i = 1; i < strings.Length; i++)
				{
					//Compare the list of strings, receiving its current sorted order.
					//Look at the current sorting, determine if the previous item is
					//correctly positioned. If it is, CompareString will return true.
					//If 
					//  TRUE = !FALSE(Apple , Accept)
					if(!CompareStrings(strings[i - 1], strings[i]))
					{
						string temp = strings[i - 1];
						strings[i - 1] = strings[i];
						strings[i] = temp;
						changed = true;
					}
				}
			}
			return strings;
		}

		/// <summary>
		/// Compare 2 strings, if str1 is alphabetically first, it would return true.
		/// 
		/// If str2 were alphabetically first, it would return false.
		/// </summary>
		/// <param name="str1">First string to compare</param>
		/// <param name="str2">Second string to compare</param>
		/// <returns></returns>
		public bool CompareStrings(string str1, string str2)
		{
			int i = 0;
			//While str1 length is less than i and str2 length is less than i
			//While we are still in the word for both words
			while(i < str1.Length && i < str2.Length)
			{
				//If str1 at index i and str2 at i are equal..
				if(str1[i] == str2[i])
				{
					//If they are equal, incremenet i;
					i++;
				}
				else
				{
					//If they are not equal, check and determine if str1[i]
					//is less than str2[i]. If str1[i] is less than str2[i],
					//return true. Otherwise, return false.										
					return str1[i] < str2[i];
					//If str1 were Accept
					//And str2 were Apple
					//And i = 2
					//This would return true.
				}
			}

			//Is str1.Length is less than str2.Length, return true.
			//Apple vs Apples
			return str1.Length <= str2.Length;
		}



		public string[] ReadInput(string filename)
		{
			StreamReader reader = new StreamReader(filename);
			string line = reader.ReadToEnd();

			reader.Close();

			string[] names = line.Split(',');

			for (int i = 0; i < names.Length; i++)
			{
				names[i] = names[i].Trim('"');
			}

			return names;
		}
	}
}
