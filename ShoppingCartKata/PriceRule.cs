namespace ShoppingCartKata
{
    public class PriceRule
    {
        public readonly string Item;
        public readonly int Price;

        public PriceRule(string item, int price)
        {
            Item = item;
            Price = price;
        }
    }
}
