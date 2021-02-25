using System;
using VitosPizza.Lib;

namespace VitosPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory factory = new PizzaFactory();

            Console.WriteLine(factory.ProducePizza("Anchovy").ToString());
            Console.WriteLine(factory.ProducePizza("Margarita").ToString());
            Console.WriteLine(factory.ProducePizza("Vesuvio").ToString());
        }
    }
}
