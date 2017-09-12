using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFuncsActionsPreds
{

    //class MeDelegate { } 

    class Program
    {
        static void Main(string[] args)
        {
            int currentTutorial = 4;

            switch (currentTutorial)
            {
                case 1:
                    DelReview review = new DelReview();
                    review.Run();
                    break;
                case 2:
                    DelTargets target = new DelTargets();
                    target.Run();
                    break;
                case 3:
                    DelWhy why = new DelWhy();
                    why.Run();
                    break;
                case 4:
                    LambdaReview lamb = new LambdaReview();
                    lamb.Run();
                    break;
                default:
                        break;
            }
        Console.ReadLine();
        }

        
    }
}
