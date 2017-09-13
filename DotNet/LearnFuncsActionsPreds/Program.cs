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
            int currentTutorial = 6;

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
                case 5:
                    DelChaining chn = new DelChaining();
                    chn.Run();
                    break;
                case 6:
                    MulticastDele multi = new MulticastDele();
                    multi.Run();
                    break;
                case 7:
                    FuncsActs am = new FuncsActs();
                    am.Run();
                    break;
                case 8:
                    AnonMethodsVsLambdas ams = new AnonMethodsVsLambdas();
                    ams.Run();
                    break;
                default:
                        break;
            }
        Console.ReadLine();
        }

        
    }
}
