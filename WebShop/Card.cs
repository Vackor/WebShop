using Microsoft.AspNetCore.Components;

namespace WebShop
{
    public class Card
    {
        private string name;
        private int price;
        private string description;
        private string imageUrl;
        private int color;
        private bool inStock;

        public Card(string name, int price, string description, string imageUrl, int color, bool inStock)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.imageUrl = imageUrl;
            this.color = color;
            this.inStock = inStock;
        }

        public string Name { get { return name; } set { name = value; } }
        public int Price { get { return price; } set { price = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string ImageUrl { get { return imageUrl; } set { imageUrl = value; } }
        public int Color { get { return color; } set { color = value; } }
        public bool InStock { get { return inStock; } set { inStock = value; } }

        NavigationManager NavigationManager { get; }

        public void onSelected()
        {
            Global.theChosenOne = this;
        }
    }
}
