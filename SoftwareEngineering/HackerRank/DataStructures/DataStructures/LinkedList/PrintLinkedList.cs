using System;
namespace DataStructures.LinkedList
{
    public class PrintLinkedList
    {
        static void printLinkedList(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public static void PrintList(SinglyLinkedListNode head)
        {
            Console.Write($"{head.data} -> ");
            if (head.next != null)
            {
                PrintList(head.next);
            }
            else
            {
                Console.Write("Null");
                Console.WriteLine();
            }

        }
    }
}
