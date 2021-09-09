using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P003
{
	class AltSolution
	{
		public void Run()
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			const long numm = 600851475143;
			long newnumm = numm;
			long largestFact = 0;


			int counter = 2;

			//While counter^2  <= newnumm
			while(counter * counter <= newnumm)
			{
				if (newnumm % counter == 0)
				{
					newnumm = newnumm / counter;
					largestFact = counter;
				}
				else
				{
					counter = (counter == 2) ? 3 : counter + 2;
					//counter++;
				}
			}

			if (newnumm > largestFact)
			{
				largestFact = newnumm;
			}

			Console.WriteLine(largestFact);
			Console.WriteLine(sw.Elapsed);

        }


	}
}
