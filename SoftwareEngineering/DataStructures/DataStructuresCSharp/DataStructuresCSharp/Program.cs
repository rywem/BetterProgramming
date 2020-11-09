using System;
using System.Collections.Generic;
using DataStructuresCSharp.LinkedList;
namespace DataStructuresCSharp
{
    class Program
    {
        /// <summary>
        /// A location to practice data structures.
        /// </summary>
        /// <param name="args"></param>
        /// <remarks>https://www.csharpstar.com/</remarks>
        static void Main( string[] args )
        {
            DataStructuresCSharp.LinkedList.LinkedList list = new DataStructuresCSharp.LinkedList.LinkedList();
            Node node = list.CreateNode(1);

            node = list.InsertAtBeginning(node, 0);
            list.InsertAtEnd(node, 2);
            list.Print(node);
            Console.WriteLine(list.Count(node));
        }
    }
}
