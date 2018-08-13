using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_Add2Numbers_Returns2Count()
        {
            BusinessLib.Fundamentals.Stack<int> stack = new BusinessLib.Fundamentals.Stack<int>();
            stack.Push(1);
            stack.Push(3);
            Assert.That(stack.Count, Is.EqualTo(2));
        }
        [Test]
        public void Peek_AddItemsToStack_PeeksLastItem()
        {
            BusinessLib.Fundamentals.Stack<int> stack = new BusinessLib.Fundamentals.Stack<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(4);
            Assert.That(stack.Count, Is.EqualTo(3));
            var result = stack.Peek();
            Assert.That(result, Is.EqualTo(4));
            Assert.That(stack.Count, Is.EqualTo(3));
        }
        [Test]
        public void Pop_PopLastItem_ItemIsCorrectAndStackIsDecreased()
        {
            BusinessLib.Fundamentals.Stack<int> stack = new BusinessLib.Fundamentals.Stack<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(4);
            Assert.That(stack.Count, Is.EqualTo(3));
            var result = stack.Pop();
            Assert.That(result, Is.EqualTo(4));
            Assert.That(stack.Count, Is.EqualTo(2));
        }
    }
}
