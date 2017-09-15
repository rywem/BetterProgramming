using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_PLINQ_Async_Tasks.PLINQ
{
    public class WordReversal
    {
        public void Run()
        {
            //Reverse();
            ReverseWithPLINQ();

        }

        /// <summary>
        /// As a single thread
        /// </summary>
        void Reverse()
        {
            string sentence = "the quick brown fox jumped over the lazy dog";
            var words = sentence.Split().Select(word => new string(word.Reverse().ToArray()));
            Console.WriteLine(string.Join(" ", words));
        }

        /// <summary>
        /// Using parallel linq
        /// </summary>
        void ReverseWithPLINQ()
        {
            //.AsParallel() and .AsSequential() switches between parallel and sequential LINQ
            string sentence = "the quick brown fox jumped over the lazy dog";
            var words = sentence.Split()
                .AsParallel() //Now the expression is a parallel linq expression
                .Select(word => new string(word.Reverse().ToArray()));
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
