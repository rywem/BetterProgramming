using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Web.Tests
{
    [TestClass]
    public class CatalogTest
    {
        #region product tests

        [TestMethod]
        public void Product_Discount_Amount_Is_Valid()
        {
            Commerce.Data.Database.Product product = new Data.Database.Product();
            product.ListPrice = 100;
            product.DiscountPercent = 40;
            Assert.AreEqual(product.DiscountAmount, 40);

        }
        [TestMethod]
        public void Product_Discount_Price_IsValid()
        {
            Commerce.Data.Database.Product product = new Data.Database.Product();
            product.ListPrice = 100;
            product.DiscountPercent = 40;
            Assert.AreEqual(product.DiscountPrice, 60);
        }

        #endregion

    }
}
