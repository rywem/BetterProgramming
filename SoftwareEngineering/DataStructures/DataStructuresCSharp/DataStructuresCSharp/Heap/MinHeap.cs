using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresCSharp.Heap
{
   public class MinHeap : Heap
   {
      public MinHeap() : base()
      {

      }
      
      public override void HeapifyUp()
      {
         int index = Size - 1;
         // Walk up as long as there's a parent item and 
         // as long as the child is less than the parent
         while ( HasParent(index) && Parent(index) > Items[index] )
         {
            Swap(GetParentIndex(index), index); // Swap the parent and the child
            // Travel upwards
            index = GetParentIndex(index);
         }
      }

      public override void HeapifyDown()
      {
         int index = 0;
         // As long as the index has child, keep walking down and fix the heap
         // only check if there's a left child, if there's no left child, there is certainly no right child
         while ( HasLeftChild(index) )
         {
            int smallerChildIndex = GetLeftChildIndex(index);
            // If there's a right child, and the right child is less than the left child
            if (HasRightChild(index) && RightChild(index) < LeftChild(index) )
               smallerChildIndex = GetRightChildIndex(index);

            // If Items of index are smaller than the smaller of the two children
            if ( Items[index] < Items[smallerChildIndex] )
               break;
            else            
               Swap(index, smallerChildIndex); // Swap values

            // Move down to the smaller child
            index = smallerChildIndex; 
         }
      }
   }
}
