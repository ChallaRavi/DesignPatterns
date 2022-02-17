using static System.Console;
using AbstractFactory.AbstractFactoryInterfaces;

namespace AbstractFactory.Product
{

    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class Wolf : ICarnivore
    {
        // Eat Bison
        public void Eat(IHerbivore h) =>
            WriteLine($"{GetType().Name} eats {h.GetType().Name}");
    }
}
