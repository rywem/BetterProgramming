using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P018
{
	class MaximumSumTriangle
	{
		public void Run()
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();

			string filename = @"F:\ProjectEuler\P018\input.txt";


			int[,] inputTriangle = ReadInput(filename);
			int lines = inputTriangle.GetLength(0);

			for(int i = lines - 2; i >= 0; i--)
			{
				for(int j = 0; j <= i; j++)
				{
					inputTriangle[i, j] += Math.Max(inputTriangle[i + 1, j], inputTriangle[i + 1, j + 1]);
				}
			}

			Console.WriteLine(inputTriangle[0, 0]);
			Console.WriteLine(sw.Elapsed);
		}

		private int[,] ReadInput(string filename)
		{
			string line;
			string[] linePieces;
			int lines = 0;

			StreamReader reader = new StreamReader(filename);

			while((line = reader.ReadLine()) != null)
			{
				lines++;
			}

			int[,] inputTriangle = new int[lines, lines];

			reader.BaseStream.Seek(0, SeekOrigin.Begin);

			int j = 0;

			while((line = reader.ReadLine()) != null)
			{
				linePieces = line.Split(' ');

				for(int i = 0; i <linePieces.Length; i++)
				{
					inputTriangle[j, i] = int.Parse(linePieces[i]);
				}
				j++;
			}
			reader.Close();
			return inputTriangle;
		}
	}
}
