Participants

The classes and/or objects participating in this pattern are:

• AbstractFactory (ContinentFactory) 
o declares an interface for operations that create abstract products 
• ConcreteFactory (AfricaFactory, AmericaFactory) 
o implements the operations to create concrete product objects 
• AbstractProduct (Herbivore, Carnivore)
o declares an interface for a type of product object 
• Product (Wildebeest, Lion, Bison, Wolf) 
o defines a product object to be created by the corresponding concrete factory 
implements the AbstractProduct interface 
• Client (AnimalWorld) 
o uses interfaces declared by AbstractFactory and AbstractProduct classes 