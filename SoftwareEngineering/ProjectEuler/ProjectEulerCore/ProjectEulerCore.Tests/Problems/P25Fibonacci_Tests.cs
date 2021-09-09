using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ProjectEulerCore.Problems;
using System.Numerics;

namespace ProjectEulerCore.Tests.Problems
{
    public class P25Fibonacci_Tests
    {
        [Fact]
        public void CalculateFibonacci_Index1_Returns1()
        {
            P25Fibonacci fib = new P25Fibonacci();
            BigInteger actual = fib.CalculateFibonacci(1);
            BigInteger expected = 1;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CalculateFibonacci_Index2_Returns1()
        {
            P25Fibonacci fib = new P25Fibonacci();
            BigInteger actual = fib.CalculateFibonacci(2);
            BigInteger expected = 1;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateFibonacci_Index3_Returns2()
        {
            P25Fibonacci fib = new P25Fibonacci();
            BigInteger actual = fib.CalculateFibonacci(2);
            BigInteger expected = 1;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        public void CalculateFibonacci(int index, BigInteger expected)
        {
            P25Fibonacci fib = new P25Fibonacci();
            BigInteger actual = fib.CalculateFibonacci(index);            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 1)]
        [InlineData(22, 2)]
        [InlineData(323, 3)]
        public void CalculateLength_Length1_Returns1(int numberToCheck, int expected)
        {
            P25Fibonacci fib = new P25Fibonacci();
            int actual = fib.CalculateLength(numberToCheck);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetFirstIndexWithLength()
        {
            P25Fibonacci fib = new P25Fibonacci();
            int actual = fib.GetFirstIndexWithLength(2);
            int expected = 7;
            Assert.Equal(expected, actual);
        }
    }
}
