using BusinessLib.Mocking;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.UnitTests.Mocking
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount()
        {
            var product = new Product() { ListPrice = 100 };
            var result = product.GetPrice(new Customer() { IsGold = true });

            Assert.That(result, Is.EqualTo(70));
        }
    }
}
