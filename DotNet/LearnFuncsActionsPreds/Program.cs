using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFuncsActionsPreds
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int currentTutorial = 11;

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
                    DelChainException exc = new DelChainException();
                    exc.Run();
                    break;
                case 9:
                    AnonMethodsVsLambdas ams = new AnonMethodsVsLambdas();
                    ams.Run();
                    break;
                case 10:
                    Closures cams = new Closures();
                    cams.Run();
                    break;
               
                default:
                        break;
            }
        Console.ReadLine();
        }

        
    }
}
