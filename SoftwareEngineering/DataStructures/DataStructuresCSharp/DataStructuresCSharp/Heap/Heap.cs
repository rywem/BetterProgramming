using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresCSharp.Heap
{
   /// <summary>
   /// https://www.youtube.com/watch?v=t0Cq6tVNRBA
   /// </summary>
   public abstract class Heap
   {
      public int Capacity { get; set; }
      public int Size { get; set; }
      public int[] Items { get; set; }
      public Heap()
      {
         this.Capacity = 10;
         this.Size = 0;
         this.Items = new int[Capacity];
      }

      /// <summary>
      /// Fix the heap looking upwards. Swapping each element with its parent
      /// </summary>
      public abstract void HeapifyUp();
      /// <summary>
      /// Fix the heap looking downwards
      /// </summary>
      public abstract void HeapifyDown();
      /// <summary>
      /// Swaps the values at two indices
      /// </summary>
      public void Swap( int indexOne, int indexTwo )
      {
         int temp = Items[indexOne];
         Items[indexOne] = Items[indexTwo];
         Items[indexTwo] = temp;
      }

      public void EnsureExtraCapacity()
      {
         if ( Size == Capacity )
         {
            Array.Copy(Items, Items, Capacity * 2);
            Capacity *= 2;
         }
      }

      /// <summary>
      /// Peeks the value of the Heap
      /// </summary>
      /// <returns>Returns the root element of the Heap</returns>
      public int Peek()
      {
         if ( Size == 0 )
            throw new InvalidOperationException();

         return Items[0];
      }

      /// <summary>
      /// Extracts root element from the array.
      /// </summary>
      /// <returns>The root element</returns>
      public int Poll()
      {
         if ( Size == 0 )
            throw new InvalidOperationException();

         int item = Items[0];
         Items[0] = Items[Size - 1];
         Size--;
         HeapifyDown();
         return item;
      }

      public void Add(int item )
      {
         EnsureExtraCapacity();
         Items[Size] = item;
         Size++;
      }



      #region Basic methods

      public int GetLeftChildIndex( int parentIndex )
      {
         return 2 * parentIndex + 1;
      }

      public int GetRightChildIndex( int parentIndex )
      {
         return 2 * parentIndex + 2;
      }

      public int GetParentIndex(int childIndex)
      {
         return (childIndex - 1) / 2;
      }

      public bool HasLeftChild(int index )
      {
         return GetLeftChildIndex(index) < Size;
      }

      public bool HasRightChild(int index)
      {
         return GetRightChildIndex(index) < Size;
      }

      public bool HasParent(int index)
      {
         return GetParentIndex(index) >= 0;
      }

      public int LeftChild(int index )
      {
         return Items[GetLeftChildIndex(index)];
      }
      public int RightChild(int index)
      {
         return Items[GetRightChildIndex(index)];
      }

      public int Parent(int index)
      {
         return Items[GetParentIndex(index)];
      }
      #endregion
   }
}
