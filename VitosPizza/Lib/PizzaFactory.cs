namespace VitosPizza.Lib
{
    public class PizzaFactory
    {
        public Pizza ProducePizza(string name)
        {
            switch (name)
            {
                case "Vesuvio"  : return new Pizza("Vesuvio", new string[] { "Tomato", "cheese", "egg", "basil" });
                case "Anchovy"  : return new Pizza("Anchovy", new string[] { "Tomato", "cheese", "red onion", "basil", "anchovies" });
                default         : return new Pizza("Margarita", new string[] { "tomato", "cheese", "oregano" });
            }
        }
    }
}
