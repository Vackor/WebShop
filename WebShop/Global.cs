namespace WebShop
{

    public static class Global
    {
        public static bool loggedIn = false;

        public static List<Card> cards = new List<Card>();

        public static string[] names = { "Chocolate", "Vanilla", "Punch", "Bubble Gum", "Green Apple", "Stracciatella", "Red Velvet" };
        public static int[] prices = { 1200, 2500, 7500, 4600, 5300, 2600, 8600 };
        public static string[] descriptions = { "Made of milk chocolate", "Made of vanilla I guess", "Probably I should have studied more in high school", "Made of smurfs by Gargamel itself", "Made of... dunno, apples?", "I have no clue", "Definitely NOT made of velvet" };
        public static string[] urls = {   "https://hips.hearstapps.com/hmg-prod/images/190328-chocolate-ice-cream-020-1553897042.jpg?crop=1.00xw%3A0.846xh%3B0%2C0.0409xh&resize=480%3A270",
                            "https://www.seriouseats.com/thmb/BgKuU1qMxZQFEj4Bo8Fa9wtfExQ=/3695x2078/smart/filters:no_upscale()/__opt__aboutcom__coeus__resources__content_migration__serious_eats__seriouseats.com__recipes__images__2015__12__20151202-scotch-vanilla-ice-cream-max-falkowitz-ce3b720c669a415ea9147426d809a5c9.jpg",
                            "http://images6.fanpop.com/image/photos/34500000/Yummy-Pink-Ice-Cream-pink-color-34590641-900-600.jpg",
                            "https://homemadehooplah.com/wp-content/uploads/2021/05/cotton-candy-ice-cream-social-1.jpg",
                            "https://media.istockphoto.com/photos/lime-ice-cream-on-table-picture-id995543426?k=20&m=995543426&s=612x612&w=0&h=aSCdOQtqTcPb-u1je5JCn7pGopyyQ_WepATH6BZO27g=",
                            "https://www.moevenpick-icecream.com/sites/default/files/styles/product_detail_image/public/products/photos/stracciatella.png?itok=jEQVC_Kx",
                            "https://i.ytimg.com/vi/zO6n37lZvMg/maxresdefault.jpg" };
        public static int[] colors = { 5, 3, 4, 1, 2, 6, 0 };
        public static bool[] stocks = { true, true, true, false, false, true, false };

        public static Card theChosenOne;

        public static List<CartElement> products = new List<CartElement>();

    }
}
