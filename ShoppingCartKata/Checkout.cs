using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartKata
{
    public class Checkout
    {
        private List<PriceRule> _rules;
        private decimal _total;

        public Checkout(IEnumerable<PriceRule> rules)
        {
            _rules = rules.ToList();
        }

        public void Scan(string item)
        {
            var priceToAdd = _rules.First(x => x.Item == item).Price;

            _total += priceToAdd;
        }

        public decimal Total { get => _total; }
    }
}
