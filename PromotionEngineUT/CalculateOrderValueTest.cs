using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using PromotionEngineBL;

namespace PromotionEngineUT
{
    [TestClass]
    public class CalculateOrderValueTest
    {
        private CalculateOrderValue orderCalculator;
        private IPromotionEngineCalculator promotionEngine;
        private SKU sku;
        [TestInitialize]
        public void Init()
        {
            Dictionary<char,double> itemsByPrice = new Dictionary<char, double>();
            itemsByPrice.Add('A',50);
            itemsByPrice.Add('B',30);
            itemsByPrice.Add('C',20);
            itemsByPrice.Add('D',15);

            sku = new SKU(itemsByPrice);
            promotionEngine = new PromotionEngineStrategyOne();
            orderCalculator = new CalculateOrderValue(promotionEngine);
        }

        [TestMethod]
        public void GetTotalOrderValue_ShouldReturn100forABC()
        {
            //Arrange

            sku.AddToSKU('A');
            sku.AddToSKU('B');
            sku.AddToSKU('C');

            //Act

            var result = orderCalculator.GetTotalOrderValue(sku);

            //Assert

            Assert.AreEqual(100.0,result);
        }

        [TestMethod]
        public void GetTotalOrderValue_ShouldReturn370for5A5BC()
        {
            //Arrange

            sku.AddToSKU('A');
            sku.AddToSKU('A');
            sku.AddToSKU('A');
            sku.AddToSKU('A');
            sku.AddToSKU('A');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('C');

            //Act

            var result = orderCalculator.GetTotalOrderValue(sku);

            //Assert

            Assert.AreEqual(370.0, result);
        }

        [TestMethod]
        public void GetTotalOrderValue_ShouldReturn280for3A5BCD()
        {
            //Arrange

            sku.AddToSKU('A');
            sku.AddToSKU('A');
            sku.AddToSKU('A');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('C');
            sku.AddToSKU('D');

            //Act

            var result = orderCalculator.GetTotalOrderValue(sku);

            //Assert

            Assert.AreEqual(280.0, result);
        }


    }
}
