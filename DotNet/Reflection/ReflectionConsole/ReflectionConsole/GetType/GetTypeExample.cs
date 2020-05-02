using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionConsole.GetType
{
    public class MyClass { }
    public class GetTypeExample
    {
        public void Run()
        {
            Type t1 = typeof(MyClass);
            Console.WriteLine($"Type is {t1.FullName}");

            System.Object myClassObj = new MyClass();
            Type t2 = myClassObj.GetType();
            Console.WriteLine($"Type is {t2.FullName}");

            Type t3 = System.Type.GetType("ReflectionConsole.GetType.MyClass");
            Console.WriteLine($"Type is {t3.FullName}");
        }
    }
}
