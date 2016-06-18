using System.Collections.Generic;
using Folkefinans.StockProductivityCalculator.BusinessLogic;
using Folkefinans.StockProductivityCalculator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace Folkefinans.StockProductivityCalculator.BusinessLogicTests
{
    [TestClass]
    public class StockBusinessLogicTests
    {
        private static readonly StandardKernel Kernel = new StandardKernel(new TestBindings());
        
        private readonly IStockBusinessLogic _stockBusinessLogic = Kernel.Get<IStockBusinessLogic>();
        private Stock GetTestStock()
        {
            return new Stock()
            {
                Name = "Apple",
                Price = 2,
                Quantity = 200,
                Percentage = 3,
                Years = 10
            };
        }

        [TestMethod]
        public void TestYear0()
        {
            var stock = GetTestStock();
            var result = new List<Productivity>(_stockBusinessLogic.CalculateProductivity(stock));
            Assert.AreEqual(result[0].Value, 400.00M);
        }

        [TestMethod]
        public void TestYear1()
        {
            var stock = GetTestStock();
            var result = new List<Productivity>(_stockBusinessLogic.CalculateProductivity(stock));
            Assert.AreEqual(result[1].Value, 412.00M);
        }

        [TestMethod]
        public void TestYear2()
        {
            var stock = GetTestStock();
            var result = new List<Productivity>(_stockBusinessLogic.CalculateProductivity(stock));
            Assert.AreEqual(result[2].Value, 424.36M);
        }

        [TestMethod]
        public void TestYear3()
        {
            var stock = GetTestStock();
            var result = new List<Productivity>(_stockBusinessLogic.CalculateProductivity(stock));
            Assert.AreEqual(result[3].Value, 437.09M);
        }

        [TestMethod]
        public void TestYear4()
        {
            var stock = GetTestStock();
            var result = new List<Productivity>(_stockBusinessLogic.CalculateProductivity(stock));
            Assert.AreEqual(result[4].Value, 450.20M);
        }

        [TestMethod]
        public void TestYear5()
        {
            var stock = GetTestStock();
            var result = new List<Productivity>(_stockBusinessLogic.CalculateProductivity(stock));
            Assert.AreEqual(result[5].Value, 463.71M);
        }

        [TestMethod]
        public void TestYear6()
        {
            var stock = GetTestStock();
            var result = new List<Productivity>(_stockBusinessLogic.CalculateProductivity(stock));
            Assert.AreEqual(result[6].Value, 477.62M);
        }

        [TestMethod]
        public void TestYear7()
        {
            var stock = GetTestStock();
            var result = new List<Productivity>(_stockBusinessLogic.CalculateProductivity(stock));
            Assert.AreEqual(result[7].Value, 491.95M);
        }

        [TestMethod]
        public void TestYear8()
        {
            var stock = GetTestStock();
            var result = new List<Productivity>(_stockBusinessLogic.CalculateProductivity(stock));
            Assert.AreEqual(result[8].Value, 506.71M);
        }

        [TestMethod]
        public void TestYear9()
        {
            var stock = GetTestStock();
            var result = new List<Productivity>(_stockBusinessLogic.CalculateProductivity(stock));
            Assert.AreEqual(result[9].Value, 521.91M);
        }

        [TestMethod]
        public void TestYear10()
        {
            var stock = GetTestStock();
            var result = new List<Productivity>(_stockBusinessLogic.CalculateProductivity(stock));
            Assert.AreEqual(result[10].Value, 537.57M);
        }
    }
}
