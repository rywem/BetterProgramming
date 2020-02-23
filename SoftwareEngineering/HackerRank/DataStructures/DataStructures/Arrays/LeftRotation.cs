using System;
namespace DataStructures.Arrays
{
    public class LeftRotation
    {
        public LeftRotation()
        {
        }
        public static void Run()
        { 
            string input = @"5 4
1 2 3 4 5";
            //string[] nd = Console.ReadLine().Split(' ');

            int n = 5; // Convert.ToInt32(nd[0]);

            int d = 4; // Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll("1 2 3 4 5".Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            int[] array = new int[n];
            //insert solution here:
            for (int i = 0; i < n; i++)
            {
                array[(i + n - d) % n] = a[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }


    }
}
