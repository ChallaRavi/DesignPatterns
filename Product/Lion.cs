using static System.Console;
using AbstractFactory.AbstractFactoryInterfaces;


namespace AbstractFactory.Product
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    public class Lion : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            // Eat Wildebeest
            WriteLine($"{GetType().Name} eats {herbivore.GetType().Name} ");
        }
    }
}
