using AbstractFactory.AbstractFactoryInterfaces;
using AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactories.ConcreteFactory1
{
    internal class America : IContinentFactory
    {
        public ICarnivore CreateCarnivore() => new Wolf();
        

        public IHerbivore CreateHerbivore() => new Bison();
    }
}
