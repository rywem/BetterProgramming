using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ProjectEulerCore.Problems
{
    public class P25Fibonacci
    {
        private Dictionary<int, BigInteger> _fibDict;
        public P25Fibonacci()
        {
            this._fibDict = new Dictionary<int, BigInteger>();
        }

        private void AddToDictionary(int indexKey, BigInteger value)
        {
            _fibDict.Add(indexKey, value);
        }

        private BigInteger GetFromDictionary(int index)
        {
            return _fibDict[index];
        }        

        public BigInteger CalculateFibonacci(int index)
        {
            if(index == 1 || index == 0)
                return new BigInteger(index);
            return GetFromDictionary(index - 1) + GetFromDictionary(index - 2);            
        }

        public int CalculateLength(BigInteger n)
        {
            string x = n.ToString();
            return x.Length;
        }

        public int GetFirstIndexWithLength(int targetLength)
        {
            int indexCounter = 0;
            while(true)
            {
                BigInteger result = CalculateFibonacci(indexCounter);
                AddToDictionary(indexCounter, result);
                int length = CalculateLength(result);
                if (targetLength == length)
                    return indexCounter;
                if(indexCounter % 10 == 0)
                    Console.WriteLine($"index: {indexCounter} length: {length} result: {result}");
                indexCounter++;
            }            
        }
    }
}
