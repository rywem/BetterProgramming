using System;
using System.Text;
namespace BitwiseWorkspace
{
    //https://www.youtube.com/watch?v=tNO05yKSQcU
    public class BitwiseBasicsReview
    {
        public BitwiseBasicsReview()
        {

        }

        public void Run()
        {
            //var a = true;

            //if (a == true)
            //    a = false;
            //else
            //    a = true;

            //a ^= a; //invert

            //Console.WriteLine(a);
            var a = 25;
            PrintToByte(a);
            var b = 7;
            PrintToByte(b);


            var result = a | b;
            PrintToByte(result);
            //Console.WriteLine("result: " + Convert.ToString(result, 2).PadLeft(8, '0'));

            //  Bitwise operators
            //      AND &   (Both)
            //      OR  |   (Either)
            //      XOR ^   (Exclusive or, different)
            //      Not ~   (Invert)

            //  Bitwise shifting
            //      Left    <<
            //      Right   >>  

            //  Usage
            //      Toggling boolean
            //      Enum flags
            //      Masking            
        }

        public void PrintToByte(int input)
        {
            Console.WriteLine(Convert.ToString(input, 2).PadLeft(8, '0'));
        } 
    }
}
