using System;
using System.IO;

namespace DataStructures.Arrays
{
    public class TwoDArray
    {
        public TwoDArray()
        {
        }

        public static void Run()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            string array = @"1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0";
            int[][] arr = new int[6][];
            string[] stringArray = array.Split('\n');
            for (int i = 0; i < 6; i++)
            {
                string[] innerArray = stringArray[i].Split(' ');
                int[] newIntArray = Array.ConvertAll(innerArray, arrTemp => Convert.ToInt32(arrTemp));
                //arr[i] = Array.ConvertAll(stringArray[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                arr[i] = newIntArray;
            }

            int result = hourglassSum(arr);
        }

        public static int hourglassSum(int[][] arr)
        {
            int result = -1000;

            int maxRow = arr.GetLength(0);
            int maxColumn = arr[0].GetLength(0);
            for (int i = 0; i < maxRow; i++)
            {
                if (maxRow -1 - i < 2)
                    continue;

                for (int j = 0; j < maxColumn; j++)
                {
                    if (maxColumn -1 - j < 2)
                        continue;

                    int currentSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2];

                    currentSum += arr[i + 1][j + 1];
                    currentSum += arr[i + 2][j] + arr[i + 2][j+1] + arr[i + 2][j+ 2];

                    if (currentSum > result)
                        result = currentSum;
                }
            }

            return result;

        }
    }
}
