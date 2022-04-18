namespace WebShop.Pages
{
    public partial class IceCream
    {
        bool onlyInStock = false;
        int setMax;
        int setMin;
        int minPrice;
        int maxPrice;

        static bool[] checkboxes = { true, true, true, true, true, true, true };

        public IceCream()
        {
            if (Global.cards.Count == 0)
            {
                for (int i = 0; i < Global.names.Length; i++)
                {
                    Global.cards.Add(new Card(Global.names[i], Global.prices[i], Global.descriptions[i], Global.urls[i], Global.colors[i], Global.stocks[i])); ;
                }
            }
            minPrice = Global.prices.Min();
            maxPrice = Global.prices.Max();
            setMin = minPrice;
            setMax = maxPrice;
            
        }
    }
}
