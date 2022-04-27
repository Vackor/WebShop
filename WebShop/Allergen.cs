namespace WebShop
{
    public class Allergen
    {
        // name + property
        private string name;
        // does the ice cream contain it + property 
        private bool contains;

        public string Name { get { return name; } }
        public bool Contains { get { return contains; } }

        // constructor
        public Allergen(string name, bool contains)
        {
            this.name = name;
            this.contains = contains;
        }
    }
}
