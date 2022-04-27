using Microsoft.AspNetCore.Components;

namespace WebShop
{
    public class Card
    {
        // Ice cream informations
        private string name;
        private int price;
        private string description;
        private string imageUrl;
        private int color;
        private bool inStock;

        // constructor
        public Card(string name, int price, string description, string imageUrl, int color, bool inStock)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.imageUrl = imageUrl;
            this.color = color;
            this.inStock = inStock;
        }

        // properties
        public string Name { get { return name; } set { name = value; } }
        public int Price { get { return price; } set { price = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string ImageUrl { get { return imageUrl; } set { imageUrl = value; } }
        public int Color { get { return color; } set { color = value; } }
        public bool InStock { get { return inStock; } set { inStock = value; } }

        // to navigate between pages, getter
        NavigationManager NavigationManager { get; }

        // this function runs when the user clicks see more... on an item
        public void onSelected()
        {
            Global.theChosenOne = this;
        }
    }
}
