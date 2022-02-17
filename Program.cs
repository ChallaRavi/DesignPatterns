using AbstractFactory.Client;
using AbstractFactory.ConcreteFactories.ConcreteFactory2;
using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var africa = new AnimalWorld<Africa>();
            africa.RunFoodChain();


        }
    }
}
