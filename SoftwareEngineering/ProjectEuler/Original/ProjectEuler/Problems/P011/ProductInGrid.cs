using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P011
{
	class ProductInGrid
	{
		public void Run()
		{
			//string filename = Environment.GetFolderPath(Environment.SpecialFolder.)
			string filename = @"F:\ProjectEuler\P011\input.txt";

			const int numbersInProduct = 4;

			decimal product = 0;

			int[,] inputSquare = readInput(filename);


			/*
			
			for (int i = 0; i < inputSquare.GetLength(0); i++)
			{
				for (int j = 0; j < inputSquare.GetLength(1); j++)
				{
					Console.Write("{0,3}",inputSquare[i,j]);
				}
				Console.WriteLine();
			}
			*/

			for (int col = 0; col < inputSquare.GetLength(0); col++)
			{
				for (int row = 0; row < inputSquare.GetLength(1); row++)
				{
					decimal tempProd;

					//Check Vertically					
					if (row < inputSquare.GetLength(0) - numbersInProduct)
					{
						tempProd = inputSquare[col, row];
						for (int i = 1; i < numbersInProduct; i++)
						{
							tempProd *= inputSquare[col, row + i];
						}
						product = Math.Max(product, tempProd);
					}

					//Check Horizontally
					if (col < inputSquare.GetLength(1) - numbersInProduct)
					{
						tempProd = inputSquare[col, row];
						for (int i = 1; i < numbersInProduct; i++)
						{
							tempProd *= inputSquare[col + i, row];
						}
						product = Math.Max(product, tempProd);
					}

					// Check diagonally upwards / forwards
					if ((col < inputSquare.GetLength(0) - numbersInProduct) && (row >= numbersInProduct))
					{
						tempProd = inputSquare[col, row];
						for (int i = 1; i < numbersInProduct; i++)
						{
							tempProd *= inputSquare[col + i, row - i];
						}
						product = Math.Max(product, tempProd);
					}

					// Check diagonally Downwards / forwards
					if ((row < inputSquare.GetLength(0) - numbersInProduct) && (col < inputSquare.GetLength(1) - numbersInProduct))
					{
						tempProd = inputSquare[col, row];
						for (int i = 1; i < numbersInProduct; i++)
						{
							tempProd *= inputSquare[col + i, row + i];
						}
						product = Math.Max(product, tempProd);
					}

				}
			}

			Console.WriteLine(product);


		}

		private int[,] readInput(string filename)
		{
			int lines = 0;
			string line;
			string[] linePieces;

			StreamReader reader = new StreamReader(filename);

			while (reader.ReadLine() != null)
			{
				lines++;
			}

			int[,] inputSquare = new int[lines, lines];
			reader.BaseStream.Seek(0, SeekOrigin.Begin);

			int j = 0;

			while ((line = reader.ReadLine()) != null)
			{
				linePieces = line.Split(' ');

				for (int i = 0; i < linePieces.Length; i++)
				{
					inputSquare[j, i] = int.Parse(linePieces[i]);
				}
				j++;
			}

			reader.Close();

			return inputSquare;
		}
	}
}
