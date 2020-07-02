using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace PromotionEngineUT
{
    [TestClass]
    public class PromotionEngineStrategyOneTest
    {
        private IPromotionEngineCalculator promotionEngine;
        private SKU sku;

        [TestInitialize]
        public void Init()
        {
            Dictionary<char, double> itemsByPrice = new Dictionary<char, double>();
            itemsByPrice.Add('A', 50);
            itemsByPrice.Add('B', 30);
            itemsByPrice.Add('C', 20);
            itemsByPrice.Add('D', 15);

            sku = new SKU(itemsByPrice);
            promotionEngine = new PromotionEngineStrategyOne();
        }
        [TestMethod]
        public void GetOrderValueShouldReturn0ForNoItem()
        {
            //Act
            var result = promotionEngine.GetOrderValue(sku);

            //Assert
            Assert.AreEqual(0.0,result);

        }
    }
}
