using NUnit.Framework;
using LogisticProcessor.Web.Server.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticProcessor.Web.Test.Api
{
    [TestFixture]
    public class ProductTest
    {
        private readonly ProductController productController;
        [SetUp]
        public void SetUp()
        {
            productController = new ProductController();
        }
        [Test]
        public void CanGetProduct()
        {
            Assert.That
        }
    }
}
