using System;
namespace AOCPSolution.Section1_2
{
    public class Algorithm_E
    {
        public int M { get; set; }
        public int N { get; set; }
        public Algorithm_E(int m,  int n)
        {
            if (m < 0)
                throw ArgumentException("M cannot be less than 0");
            if (n < 0)
                throw ArgumentException("N cannot be less than 0");    
            this.M = m;
            this.N = n;
        }
    }
}
