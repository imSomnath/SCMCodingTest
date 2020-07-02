using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngine;

namespace PromotionEngineBL
{
    public class CalculateOrderValue
    {
        private IPromotionEngineCalculator promotionEngineStrategy;
        public CalculateOrderValue(IPromotionEngineCalculator promotionStrategy)
        {
            promotionEngineStrategy = promotionStrategy;
        }

        public double GetTotalOrderValue(SKU sku)
        {
            return promotionEngineStrategy.GetOrderValue(sku);
        }
    }
}
