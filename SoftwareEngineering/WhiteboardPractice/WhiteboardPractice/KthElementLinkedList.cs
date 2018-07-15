using System;
namespace WhiteboardPractice
{
    /// <summary>
    /// Implement an algorithm to find the kth to last element of a singly linked list
    /// </summary>
    /// <remarks>
    /// pg 94, problem 2.2
    /// </remarks>
    public class KthElementLinkedList
    {
        public LinkedItem GetKth(LinkedItem items, int k)
        {
            int count = items.GetCount();
            int kth = count - k;
            var kthItem = items.GetItem(kth);
            return kthItem;
        }
    }

    public class LinkedItem
    {
        public LinkedItem NextItem { get; set; }
        public int Index;
        public object Data;

        public LinkedItem GetItem(int index)
        {
            if (Index != index && NextItem == null)
                return null;
            if (Index == index)
                return this;
            else
                return NextItem.GetItem(index);
        }

        public void SetItem(object data, int index = 0)
        {
            if (NextItem == null)
            {
                this.Data = data;
                this.Index = index;
            }
            else
                this.NextItem.SetItem(data, index++);
        }

        public int GetCount()
        {
            if (NextItem == null)
                return Index;
            else
                return NextItem.GetCount();
        }
    }
}
