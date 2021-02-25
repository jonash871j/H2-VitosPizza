namespace VitosPizza.Lib
{
    public class Pizza
    {
        public Pizza(string name, string[] ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }

        public string Name { get; private set; }
        public string[] Ingredients { get; private set; }

        public override string ToString()
        {
            return $"This is a {Name} pizza with {string.Join(", ", Ingredients)}";
        }
    }
}
