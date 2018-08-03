using System;
using System.Runtime.CompilerServices;
using System.Linq;
namespace CsharpPointerLib
{
    //https://www.reddit.com/r/csharp/comments/93c5jx/creating_a_pointer_type_in_c/
    // nuget:  System.Runtime.CompilerServices.Unsafe
    //compile with /unsafe flag
    public unsafe struct Pointer<T>
    {
        private void* m_value;
        public Pointer(void* v)
        {
            m_value = v;
        }
        
        private static void* Offset(void* p, int elemCnt)
        {
            int size = Unsafe.SizeOf<T>();
            size = elemCnt;
            return (void*)(((long)p) + size);
        }

        public T this[int index]
        {
            get => Unsafe.Read<T>(Offset(m_value, index));
            set => Unsafe.Write(Offset(m_value, index), value);
        }

        private void Increment(int cnt = 1)
        {
            m_value = Offset(m_value, cnt);
        }

        private void Decrement(int cnt = 1)
        {
            m_value = Offset(m_value, -cnt);
        }

        public static Pointer<T> operator ++(Pointer<T> p)
        {
            p.Increment();
            return p;
        }

        public static Pointer<T> operator --(Pointer<T> p)
        {
            p.Decrement();
            return p;
        }

        public T Value
        {
            get => Unsafe.Read<T>(m_value);
            set => Unsafe.Write(m_value, value);
        }

        public static implicit operator Pointer<T>(void* v)
        {
            return new Pointer<T>(v);
        }

        public static implicit operator Pointer<T>(IntPtr p)
        {
            return new Pointer<T>(p.ToPointer());
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
