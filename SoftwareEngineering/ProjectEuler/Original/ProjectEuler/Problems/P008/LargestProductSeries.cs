﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P008
{
	class LargestProductSeries
	{
		public void Run()
		{
			const String p =  "73167176531330624919225119674426574742355349194934" +
							  "96983520312774506326239578318016984801869478851843" +
							  "85861560789112949495459501737958331952853208805511" +
							  "12540698747158523863050715693290963295227443043557" +
							  "66896648950445244523161731856403098711121722383113" +
							  "62229893423380308135336276614282806444486645238749" +
							  "30358907296290491560440772390713810515859307960866" +
							  "70172427121883998797908792274921901699720888093776" +
							  "65727333001053367881220235421809751254540594752243" +
							  "52584907711670556013604839586446706324415722155397" +
							  "53697817977846174064955149290862569321978468622482" +
							  "83972241375657056057490261407972968652414535100474" +
							  "82166370484403199890008895243450658541227588666881" +
							  "16427171479924442928230863465674813919123162824586" +
							  "17866458359124566529476545682848912883142607690042" +
							  "24219022671055626321111109370544217506941658960408" +
							  "07198403850962455444362981230987879927244284909188" +
							  "84580156166097919133875499200524063689912560717606" +
							  "05886116467109405077541002256983155200055935729725" +
							  "71636269561882670428252483600823257530420752963450";

			long largest = 0;
			long numm = 0;


            for (int i = 0; i < p.Length-12; i++)
            {
                long number0 = long.Parse(p.Substring(i, 1));
                long number1 = long.Parse(p.Substring(i + 1, 1));
                long number2 = long.Parse(p.Substring(i + 2, 1));
                long number3 = long.Parse(p.Substring(i + 3, 1));
                long number4 = long.Parse(p.Substring(i + 4, 1));
                long number5 = long.Parse(p.Substring(i + 5, 1));
                long number6 = long.Parse(p.Substring(i + 6, 1));
                long number7 = long.Parse(p.Substring(i + 7, 1));
                long number8 = long.Parse(p.Substring(i + 8, 1));
                long number9 = long.Parse(p.Substring(i + 9, 1));
                long number10 = long.Parse(p.Substring(i + 10, 1));
                long number11 = long.Parse(p.Substring(i + 11, 1));
                long number12 = long.Parse(p.Substring(i + 12, 1));

                long product = number0 * number1 * number2 * number3 * number4 
                    * number5 * number6 * number7 * number8 * number9 * number10
                    * number11 * number12;

                if (product > largest)
                    largest = product;
            }

			Console.WriteLine(largest);

		}
	}
}
