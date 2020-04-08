using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresCSharp.Heap
{
    public class MaxHeap : Heap
    {
        public override void HeapifyUp()
        {
            int index = Size - 1;

            while ( HasParent(index) && Parent(index) < Items[index])
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }
        public override void HeapifyDown()
        {
            int index = 0;

            while ( HasLeftChild(index))
            {
                int largerChildIndex = GetLeftChildIndex(index);

                if ( HasRightChild(index) && RightChild(index) > LeftChild(index) )
                    largerChildIndex = GetRightChildIndex(index);
 
                if ( Items[index] > Items[largerChildIndex] )
                    break;

                if ( Items[index] < Items[largerChildIndex] )
                    break;
                else
                    Swap(index, largerChildIndex);

                index = largerChildIndex;
            }
        }
    }
}
