using System;
namespace AOCPSolution.MIX
{
    public class MixMachine
    {
        public byte[] RegisterA { get; set; }
        public byte[] RegisterI1 { get; set; }
        public byte[] RegisterI2 { get; set; } 
        public byte[] RegisterI3 { get; set; } 
        public byte[] RegisterI4 { get; set; } 
        public byte[] RegisterI5 { get; set; }
        public byte[] RegisterI6 { get; set; }
        public byte[] RegisterJ { get; set; }
        public byte[] RegisterX { get; set; }
        public bool Overflow { get; set; }
        public byte[][] MemoryCells { get; set; }
        public byte[] U { get; set; }
        public Comparison ComparisonIndicator { get; set; }
        public MixMachine()
        {
            Initialize();
        }

        public void Initialize()
        {
            RegisterA = new byte[6];
            RegisterI1  = new byte[3];
            RegisterI2 = new byte[3];
            RegisterI3 = new byte[3];
            RegisterI4 = new byte[3];
            RegisterI5 = new byte[3];
            RegisterI6 = new byte[3];
            RegisterJ = new byte[3];
            RegisterX = new byte[6];
            Overflow = false;
            MemoryCells = new byte[4000][];

            for (int i = 0; i < 4000; i++)
            {
                MemoryCells[i] = new byte[6];
            }
            U = new byte[21];
        }
        public void Contents(int M)
        {
            for (int i = 0; i < 5; i++ ) 
                Console.Write(MemoryCells[M][i] + " ");
            Console.WriteLine();
        }
        /// <summary>
        /// Load A with the Contents of Location
        /// </summary>
        /// <returns>The lda.</returns>
        /// <param name="M">M.</param>
        /// <param name="I">I.</param>
        /// <param name="F">F.</param>
        public byte[] LDA(int M, int I, int F)
        {
            var memoryObject = MemoryCells[M];
            int j = 0;
            for (int i = I; i < F; i++)
            {
                RegisterA[j] = memoryObject[i];
                j++;
            }
            return RegisterA;
        }

    }


    public enum Comparison
    {
        E,
        L,
        G
    }
}
