using LogisticProcessor.Web.Server.Controllers;
using LogisticProcessor.Web.Shared.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogisticProcessor.Web.Test.Api
{
    [TestFixture]
    public class ProductTest
    {
        private ProductController _productController;

        [SetUp]
        public void SetUp()
        {
            _productController = new ProductController();
        }
        [Test]
        public void CanGetProduct()
        {
            //var products = new Product[]
            Assert.IsNotNull(_productController.Get());
            var products = (_productController.Get() as List<Product>);

            Assert.IsNotNull((_productController.Get() as List<Product>)?.Any());
            Assert.IsTrue((_productController.Get() as List<Product>)?.Any());
        }
    }
}
