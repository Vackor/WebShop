namespace WebShop.Pages
{
    public partial class IceCream
    {
        // in stock checkbox variable
        private bool onlyInStock = false;

        // set and actual minimum and maximum prices
        private int setMax;
        private int setMin;
        private int minPrice;
        private int maxPrice;

        // color checkboxes
        static bool[] checkboxes = { true, true, true, true, true, true, true };    // red, blue, green, yellow, pink, brown, white

        // constructor
        public IceCream()
        {
            // load cards if it hasn't been done yet
            if (Global.cards.Count == 0)
            {
                Global.createCards();
            }

            // set minimum and maximum prices
            minPrice = Global.prices.Min();
            maxPrice = Global.prices.Max();
            setMin = minPrice;
            setMax = maxPrice;
        }
    }
}
