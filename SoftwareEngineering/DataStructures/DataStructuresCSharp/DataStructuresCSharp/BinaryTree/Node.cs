using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresCSharp.BinaryTree
{
   public class Node
   {
      public int Value { get; set; }
      /// <summary>
      /// Should be less than the target value.
      /// </summary>
      public Node LeftChild { get; set; } 
      /// <summary>
      /// Should be greater than the target value.
      /// </summary>
      public Node RightChild { get; set; }
   }
}
