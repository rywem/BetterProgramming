using System;


namespace CsharpPointerLib
{
    public class Address
    {
        public static IntPtr AddressOf<T>(ref T t)
        {
            TypedReference tr = __makeref(t);
            return (IntPtr)(&tr);
        }
    }
}
