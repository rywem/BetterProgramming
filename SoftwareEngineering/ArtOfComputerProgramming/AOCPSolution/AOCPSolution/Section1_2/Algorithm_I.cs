using System;
namespace AOCPSolution.Section1_2
{
    /// <summary>
    /// Mathematical Induction
    /// </summary>
    public class Algorithm_I
    {
        /// <summary>
        /// Given a positive integer n, this algorithm will output a proof that P(n) is true.
        /// </summary>
        /// <param name="n">n</param>
        public int Run(int n, int k = 1)
        {
            if (k == n)
                return n;

            var proofResult = IsEven_Proof(k + 1);

            if (proofResult)
                return Run(n, k + 1);
            else
                throw new Exception("Proof not true;");
        }

        public bool IsEven_Proof(int n)
        {
            int value = n * (n + 3);

            int half = value / 2;

            if ((half * 2) == value)
                return true;

            return false;
        }
    }
}
