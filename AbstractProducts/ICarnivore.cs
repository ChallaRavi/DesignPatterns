namespace AbstractFactory.AbstractFactoryInterfaces
{
    /// <summary>
    /// This is 'AbstractProductB' interface
    /// </summary>
    public interface ICarnivore
    {
        void Eat(IHerbivore herbivore);
    }
}