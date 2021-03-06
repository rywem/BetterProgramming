﻿using BusinessLib.Fundamentals;
using NUnit.Framework;

namespace BusinessLib.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);
            //must be exactly a NotFound
            Assert.That(result, Is.TypeOf<NotFound>());
            // may be a NotFound or a derivative of NotFound
            Assert.That(result, Is.InstanceOf<NotFound>()); 
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {

        }

    }
}
