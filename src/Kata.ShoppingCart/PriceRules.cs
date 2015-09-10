using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.ShoppingCart
{
    public class PriceRules
    {
        private Dictionary<string, int> _ruleDict = new Dictionary<string, int>();

        public PriceRules(Dictionary<string, int> ruleDictionary)
        {
            _ruleDict = ruleDictionary;
        }

        public int? PriceCheck(string sku, int qty)
        {
            string dictKey = string.Format("{0}:{1}", sku, qty);
            return _ruleDict.ContainsKey(dictKey) ? (int?)_ruleDict[dictKey] : null;
        }


    }
}
