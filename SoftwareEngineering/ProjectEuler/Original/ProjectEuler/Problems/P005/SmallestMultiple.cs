using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.P005
{
	class SmallestMultiple
	{
		public void Run()
		{
			//int number = 0;
			for (int high = 1000000000; high >= 20; high--)
			{
				for (int low = 1; low <= 20; low++)
				{
					bool status = Compare(high, low);
					
					if(status)
					{
						
					}
					else
					{
						break;
					}

					if(low == 20)
					{
						Console.WriteLine(high);
					}
				}
			}
		}

		public bool Compare(int high, int low)
		{
			if(high % low == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
