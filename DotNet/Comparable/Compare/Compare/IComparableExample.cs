using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Compare
{
    /// <summary>
    /// https://www.youtube.com/watch?v=aBXoqJRMToQ
    /// </summary>
    public class Student : IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo( [AllowNull] Student other )
        {
            if ( this.Sid > other.Sid )
                return 1;
            else if ( this.Sid < other.Sid )
                return -1;
            else
                return 0;
        }
    }
    public class IComparableExample
    {
        public static void Run()
        {
            Student s1 = new Student() { Sid = 103, Name = "Ajay", Class = 10, Marks = 575.0f };
            Student s2 = new Student() { Sid = 106, Name = "Stuart", Class = 10, Marks = 535.0f };
            Student s3 = new Student() { Sid = 104, Name = "Williams", Class = 10, Marks = 592.0f };
            Student s4 = new Student() { Sid = 102, Name = "Venkat", Class = 10, Marks = 453.0f };
            Student s5 = new Student() { Sid = 101, Name = "David", Class = 10, Marks = 512.0f };
            Student s6 = new Student() { Sid = 105, Name = "John", Class = 10, Marks = 498.0f };

            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6 };

            students.Sort();

            foreach ( var item in students )
            {
                Console.WriteLine($"{item.Sid} {item.Name} {item.Class} {item.Marks}");
            }
        }
    }
}
