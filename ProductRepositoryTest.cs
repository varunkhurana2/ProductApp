using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductApp.Infrastructure;

namespace PorductaApp.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        ProductRepository repo=null;
        [TestInitialize]
        public void TestSetup()
        {
            ProductInitalizeDB db = new ProductInitalizeDB();
            System.Data.Entity.Database.SetInitializer(db);
            repo = new ProductRepository();
        }


        [TestMethod]
        public void IsRepositoryInitalizeWithvalidNumberofData()
        {
            var result = repo.GetProducts();
            Assert.IsNotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(2, numberOfRecords);
        }
    }
}
