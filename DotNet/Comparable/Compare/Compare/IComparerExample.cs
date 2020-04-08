using System;
using System.Collections.Generic;
using System.Text;

namespace Compare
{
    public class CompareStudents : IComparer<Student>
    {
        public int Compare( Student x, Student y )
        {
            if ( x.Marks > y.Marks )
                return 1;
            else if ( x.Marks < y.Marks )
                return -1;
            else
                return 0;
        }
    }
    public class IComparerExample
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

            students.Sort(new CompareStudents());

            foreach ( var item in students )
            {
                Console.WriteLine($"{item.Sid} {item.Name} {item.Class} {item.Marks}");
            }
        }
    }
}
