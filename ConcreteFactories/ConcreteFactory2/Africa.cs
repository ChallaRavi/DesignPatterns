using AbstractFactory.AbstractFactoryInterfaces;
using AbstractFactory.Product;

namespace AbstractFactory.ConcreteFactories.ConcreteFactory2
{
    /// <summary>
    /// The 'ConcreteFactory1' class.
    /// </summary>
    public class Africa : IContinentFactory
    {
        public IHerbivore CreateHerbivore() => new Wildebeest();

        public ICarnivore CreateCarnivore() => new Lion();
    }
}
