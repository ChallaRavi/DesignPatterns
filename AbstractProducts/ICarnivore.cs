namespace AbstractFactory.AbstractFactoryInterfaces
{
    /// <summary>
    /// The 'AbstractProductB' interface
    /// </summary>
    public interface ICarnivore
    {
        void Eat(IHerbivore herbivore);
    }
}