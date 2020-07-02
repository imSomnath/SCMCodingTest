using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class SKU
    {
        private List<char> items = new List<char>();
        Dictionary<char, double> itemByPrice = new Dictionary<char, double>();

        public SKU()
        {
            itemByPrice.Add('A', 50);
            itemByPrice.Add('B',30);
            itemByPrice.Add('C',20);
            itemByPrice.Add('D',15);

            for (int i = 4; i < 26; i++)
            {
                itemByPrice.Add((char)('A'+i), 0);
            }
        }

        public void AddToSKU(char item)
        {
            items.Add(item);
        }

        public List<char> GetSKU()
        {
            return items;
        }

        public Dictionary<char, double> GetItemByPrice()
        {
            return itemByPrice;
        }
    }
}
