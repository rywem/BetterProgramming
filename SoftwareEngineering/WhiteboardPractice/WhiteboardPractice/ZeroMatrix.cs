using System;
using System.Collections.Generic;

namespace WhiteboardPractice
{
    /// <summary>
    /// Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column are set to 0
    /// </summary>
    public class ZeroMatrix
    {
        public static void RunSolution()
        {
            int[,] mxn = new int[3, 4]
            {
                {2, 3, 5, 4},
                {2, 4, 0, 3},
                {7, 6, 3, 9}
            };

            Solution(mxn);
        }

        public static void Solution(int[,] mxn)
        {

            int m = mxn.GetLength(0); // row
            int n = mxn.GetLength(1); // column
            Console.WriteLine("rows: " + m);
            Console.WriteLine("columns: " + n);
            List<int> rows = new List<int>();
            List<int> columns = new List<int>();
            PrintMatrix(mxn);
            for (int i = 0; i < m; i++) //through rows
            {
                for (int j = 0; j < n; j++) //through columns
                {
                    if(mxn[i,j] == 0)
                    {
                        rows.Add(i);
                        columns.Add(j);
                    }
                }
            }

            foreach (var row in rows)
            {
                for (int c = 0; c < n; c++)
                {
                    mxn[row, c] = 0;
                }
            }

            foreach (var column in columns)
            {
                for (int r = 0; r < m; r++)
                {
                    mxn[r, column] = 0;
                }
            }
            Console.WriteLine();
            PrintMatrix(mxn);
        }


        public static void PrintMatrix(int[,] mxn)
        {
            int m = mxn.GetLength(0); // row
            int n = mxn.GetLength(1); // column
            for (int i = 0; i < m; i++) //through rows
            {
                Console.Write("{");
                for (int j = 0; j < n; j++) //through columns
                {
                    Console.Write(" " + mxn[i, j] + "\t");
                }
                Console.Write("}");
                Console.WriteLine();
            }
        }
    }
}
