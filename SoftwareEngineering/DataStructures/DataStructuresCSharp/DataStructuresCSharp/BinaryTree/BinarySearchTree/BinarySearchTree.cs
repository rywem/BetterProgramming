using System;
using DataStructuresCSharp.BinaryTree;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresCSharp.BinaryTree.BinarySearchTree
{
   public class BinarySearchTree
   {

      public Node CreateNode(int value)
      {
         Node node = new Node()
         {
            Value = value,
            LeftChild = null,
            RightChild = null
         };
         return node;
      }

      /// <summary>
      /// Searches the Binary Search tree using recursion.
      /// </summary>
      /// <param name="node">The Tree</param>
      /// <param name="target">The target to find.</param>
      /// <returns>The found value, or null if not found.</returns>
      public Node Search(Node node, int target )
      {
         if ( node == null ) {
            Console.WriteLine($"{target} not found");
            return null;
         }

         if ( target == node.Value )
            return node;

         if ( target < node.Value )
            return Search(node.LeftChild, target);

         if ( target > node.Value )
            return Search(node.RightChild, target);

         return null;
      }

      /// <summary>
      /// Searches the Binary Search tree using a while loop.
      /// </summary>
      /// <param name="node">The Tree</param>
      /// <param name="target">The target to find.</param>
      /// <returns>The found value, or null if not found.</returns>
      public Node Search_While(Node node, int target)
      {         
         while (node != null ) 
         {
            if ( target < node.Value )
               node = node.LeftChild;
            else if ( target > node.Value )
               node = node.RightChild;
            else
               return node;
         }
         return null;
      }
      
      public Node Insert(Node rootNode, int valueToInsert )
      {         
         Node newNode = CreateNode(valueToInsert);
         if ( rootNode == null )
            rootNode = newNode;
         else
         {
            Node current = rootNode;
            Node parent;
            while ( true )
            {
               parent = current;
               if ( newNode.Value < current.Value )
               { 
                  current = current.LeftChild;
                  if ( current == null )
                  {
                     parent.LeftChild = newNode;
                     break;
                  }
               } 
               else if ( newNode.Value > current.Value )
               {
                  current = current.RightChild;
                  if (current == null)
                  {
                     parent.RightChild = newNode;
                     break;
                  }
               }
               else
               {
                  Console.WriteLine($"{valueToInsert} exists. No action taken.");
                  break;
               }
            }
         }
         return rootNode;         
      }

      /// <summary>
      /// Finds the node with the loweest value
      /// </summary>
      /// <param name="node">The tree node</param>
      /// <returns>The lowest value node</returns>
      public Node Min(Node node)
      {
         if ( node == null )
            return null;

         while ( node.LeftChild != null )
            node = node.LeftChild;

         return node;
      }

      /// <summary>
      /// Finds the node with the highest value
      /// </summary>
      /// <param name="node">The tree node</param>
      /// <returns>The highest value node</returns>
      public Node Max(Node node)
      {
         if ( node == null )
            return null;

         while ( node.RightChild != null )
            node = node.RightChild;

         return node;
      }
   }
}
