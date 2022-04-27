namespace WebShop
{
    public class CartElement
    {
        // information about a cart element + property
        private Card product;
        private int amount;

        public Card Product { get { return product; } }
        public int Amount { get { return amount; } set { amount = value; } }

        // constructor
        public CartElement(Card card, int amount)
        {
            product = card;
            this.amount = amount;
        }

        // on item deleted from cart
        public void remove()
        { 
            foreach (var item in Global.inCart)
            {
                if (item.Product.Name == this.Product.Name)
                {
                    Global.inCart.Remove(item);
                    break;
                }
            }
        }
    }
}
