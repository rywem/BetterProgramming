using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using CsharpPointerLib;
namespace Pointer_in_Csharp
{

    class Program
    {
        
        static void Main(string[] args)
        {
            string x = "hello";
           Pointer<string> pString = AddressOf(ref str);
            CsharpPointerLib.Pointer<int> pointer = new Pointer<int>(ref x);
            Console.WriteLine(pointer.ToString());

        }
        public static void* AddressOf<T>(ref T t)
        {
            TypedReference tr = __makeref(t);
            return (void*)(&tr);
        }

    }

    
   
}
