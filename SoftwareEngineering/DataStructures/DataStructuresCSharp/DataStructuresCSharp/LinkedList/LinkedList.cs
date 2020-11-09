using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresCSharp.LinkedList
{
    public class LinkedList
    {
        public Node CreateNode(int value )
        {
            return new Node()
            {
                Value = value,
                Next = null
            };
        }
        public Node InsertAtBeginning(Node start, int value )
        {
            Node newHead = CreateNode(value);
            newHead.Next = start;
            return newHead;
        }

        public Node InsertAtEnd(Node start, int value)
        {
            Node temp = start;

            while ( temp.Next != null )
                temp = temp.Next;

            temp.Next = CreateNode(value);
            return start;
        }

        public void Print(Node node )
        {
            Node temp = node;

            while ( true )
            {
                Console.WriteLine(temp.Value);
                if ( temp.Next == null )
                    break;
                else
                    temp = temp.Next;

                
            }
            
        }

        public int Count(Node start)
        {
            int counter = 0;

            Node temp = start;

            while(temp != null)
            {
                counter++;
                temp = temp.Next;
            }
            return counter;
        }

        public Node GetNodeAtPosition(Node node, int position)
        {
            Node temp;
            temp = node;

            for ( int i = 0; i < position && temp != null; i++ )
            {
                temp = temp.Next;
            }
            return temp;

        }
    }
}
