#   Participants 
- > The classes and/or objects participating in this pattern are:
 ---
### (I)AbstractFactoryInterfaces (ContinentFactory) 
-  declares an interface for operations that create abstract products 
---
### (II) ConcreteFactories (AfricaFactory, AmericaFactory) 
- implements the operations to create concrete product objects 
---
### (III) AbstractProducts (Herbivore, Carnivore)
  - declares an interface for a type of product object 
----

### (IV) Product (Wildebeest, Lion, Bison, Wolf) 
-  defines a product object to be created by the corresponding concrete factory 
implements the AbstractProduct interface 

--
### (V) Client (AnimalWorld) 
- uses interfaces declared by AbstractFactory and AbstractProduct classes.


&nbsp;

---

#### When to Think of using this Pattern (Use Cases):
- At times when the client does not know exactly what type to construct.
- Probably when we have usecases to Overload constructor, Constructors don’t communicate their intention very well because they must be 
named after their class. 