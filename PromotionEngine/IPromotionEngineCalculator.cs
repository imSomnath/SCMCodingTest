using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public interface IPromotionEngineCalculator
    { 
        double GetOrderValue(SKU sku);
    }
}
