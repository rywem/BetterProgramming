using System;
using System.Threading;

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
            SinglyLinkedListNode current = head;

            while ( true )
            {
                if (counter == position - 1)
                {
                    var newNode = new SinglyLinkedListNode(data);
                    if ( current.next != null )
                    {
                        newNode.next = current.next;

                    }
                    current.next = newNode;
                    return head;
                    
                }
                else
                {
                    current = current.next;
                    counter++;
                }
            }
        }

        public SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position)
        {
            int counter = 0;
            SinglyLinkedListNode current = head;
            SinglyLinkedListNode previous = head;

            if (position == 0)
                return head.next;
            while ( counter < position )
            {
                previous = current;
                current = current.next;
                counter++;
            }

            previous.next = current.next;

            return head;
        }

        public void reversePrint(SinglyLinkedListNode head)
        {
            if (head.next == null)
            {
                Console.WriteLine(head.data);
                return;
            }
            else
            {
                reversePrint(head.next);
            }
            Console.WriteLine(head.data);
        }

        public SinglyLinkedListNode reverse(SinglyLinkedListNode head)
        {

            if (head == null || head.next == null)
                return head;

            var remaining = reverse(head.next);

            var currentRemaining = remaining;
            while ( true )
            {
                if (currentRemaining.next == null)
                {
                    currentRemaining.next = new SinglyLinkedListNode(head.data);
                    break;
                }
                else
                {
                    currentRemaining = currentRemaining.next;
                }
            }
            return remaining;
           
        }

        public SinglyLinkedListNode reverse2(SinglyLinkedListNode head)
        {

            if (head == null || head.next == null)
                return head;

            var result = reverse(head.next);

            head.next.next = head;
            head.next = null;
            
            return result;

        }
    }
}
