using ReflectionConsole.GetType;
using System;

namespace ReflectionConsole
{
    class Program
    {
        static void Main( string[] args )
        {
            GetTypeExample example = new GetTypeExample();
            example.Run();

            Console.ReadLine();
        }
    }
}
