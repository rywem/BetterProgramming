using System;

namespace AOCPSolution
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Section1_2.Algorithm_I algI = new Section1_2.Algorithm_I();
            int output = algI.Run(4);
            Console.WriteLine(output);
        }
    }
}
