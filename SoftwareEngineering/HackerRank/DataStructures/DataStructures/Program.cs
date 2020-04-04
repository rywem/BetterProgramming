using System;
using DataStructures.LinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArraysDS.Run();
            //TwoDArray.Run();
            //LeftRotation.Run();
            //SparseArrays.Run();
            SinglyLinkedList singlyLinked = new SinglyLinkedList();

            var node = singlyLinked.insertNodeAtHead(null, 383);
            PrintLinkedList.PrintList(node);
            node = singlyLinked.insertNodeAtHead(node, 482);
            PrintLinkedList.PrintList(node);
        }
    }
}
