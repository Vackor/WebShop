namespace WebShop.Pages
{

    public partial class Product
    {
        // amount to order
        public int amount;

        // list of allergens
        private Allergen[] allergens = new[]
        {
            new Allergen("milk", true),
            new Allergen("eggs", true),
            new Allergen("tree nuts", false),
            new Allergen("peanuts", true),
            new Allergen("wheat", false)
        };

        // constructor
        public Product()
        {
            amount = 0;
        }

        // price to pay for the amount
        public int toPay() { return amount * Global.theChosenOne.Price; }

        // add to cart button callback
        public void onAddToCart()
        {
            bool found = false;
            // if item is already in cart, it increases the amount
            foreach(var item in Global.inCart)
            {
                if (item.Product.Name == Global.theChosenOne.Name)
                {
                    item.Amount += amount;
                    found = true;
                    break;
                }
            }
            // else it adds the item to the cart
            if (!found)
            {
                Global.inCart.Add(new CartElement(Global.theChosenOne, amount));
            }
            amount = 0;
        }
    }
}
