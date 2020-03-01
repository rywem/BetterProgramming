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
    }
}
