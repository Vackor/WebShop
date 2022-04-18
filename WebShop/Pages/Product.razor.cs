namespace WebShop.Pages
{

    public class Allergen
    {
        private string name;
        private bool contains;

        public string Name { get { return name; } }
        public bool Contains { get { return contains; } }

        public Allergen(string name, bool contains)
        {
            this.name = name;
            this.contains = contains;
        }
    }

    public partial class Product
    {
        int amount;
        public int toPay() { return amount * Global.theChosenOne.Price; }

        private Allergen[] allergens = new[]
        {
            new Allergen("milk", true),
            new Allergen("eggs", true),
            new Allergen("tree nuts", false),
            new Allergen("peanuts", true),
            new Allergen("wheat", false)
        };

        public Product()
        {
            amount = 0;
        }

        public void onAddToCart()
        {
            bool found = false;
            for (int i = 0; i < Global.products.Count; i++)
            {
                for (int j = 0; j < Global.cards.Count; j++)
                {
                    if (Global.products[i].Product.Name == Global.cards[j].Name)
                    {
                        found = true;
                        Global.products[i].Amount += amount;
                        break;
                    }
                }
                if (found) break;
            }
            if (!found) Global.products.Add(new CartElement(Global.theChosenOne, amount));
        }
    }
}
