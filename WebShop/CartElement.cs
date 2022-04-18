namespace WebShop
{
    public class CartElement
    {
        private Card product;
        private int amount;

        public Card Product { get { return product; } }
        public int Amount { get { return amount; } set { amount = value; } }

        public CartElement(Card card, int amount)
        {
            product = card;
            this.amount = amount;
        }
    }
}
