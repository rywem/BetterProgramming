using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P015
{
	class LatticePattern
	{
		public void Run()
		{
			MakeGrid();
		}

		public void MakeGrid()
		{
			const int gridSize = 20;
			long[,] grid = new long[gridSize + 1, gridSize + 1];

			//Initialize the grid with boundary conditions
			for(int i = 0; i < gridSize; i++)
			{
				grid[i, gridSize] = 1;
				grid[gridSize, i] = 1;
			}

			for(int i = gridSize - 1; i >= 0; i--)
			{
				for(int j = gridSize - 1; j >= 0; j--)
				{
					grid[i, j] = grid[i + 1, j] + grid[i, j + 1];
				}
			}

			long last = grid[0, 0];
			Console.WriteLine(last);
		}

		public void DrawGrid()
		{
			int gridHeight = 20;
			int gridWidth = 20;

			for (int i = 1; i <= gridHeight; i++)
			{
				for (int ii = 1; ii <= gridWidth; ii++)
				{
					Console.Write("|_");
					if(ii == gridWidth)
					{
						Console.Write("|");
					}
				}

				Console.WriteLine();
			}
		}
	}
}
