using System;
namespace DataStructures.LinkedList
{
    public class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void PrintList(SinglyLinkedListNode head)
        {
            if ( head != null )
                Console.WriteLine($"{head.data}");

            if (head.next != null )
                PrintList(head.next);
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
                this.head = node;
            else
                this.tail.next = node;

            this.tail = node;
        }

        public SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            if (head == null)
            {
                head = new SinglyLinkedListNode(data);
            }
            else
            {
                var current = head;
                while (current.next != null)
                    current = current.next;

                current.next = new SinglyLinkedListNode(data);
            }
            return head;
        }

        public SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
        {
            if (llist == null)
            {
                return new SinglyLinkedListNode(data);
            }
            else
            {
                SinglyLinkedListNode newList = new SinglyLinkedListNode(data);
                newList.next = llist;
                return newList;
            }
        }

        public SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            int counter = 0;

            while ( true )
            {



                if (counter == position)
                    break;
                else
                    counter++;
            }
            

        }
    }
}
