## Define an interface or abstract class for creating an object but let the subclasses decide which class to instantiate.
## Subclasses are responsible to create the instance of the class.

### Components:
 * The Product defines the interfaces of objects that the factory method will create.
 * The ConcreteProduct objects implement the Product interface.
 * The Creator declares the factory method, which returns an object of type Product. The Creator can also define a default implementation of the factory method.
 * The ConcreteCreator objects overrides the factory method to return an instance of a Concrete Product.

### Advantages:
 * Loose coupling - eliminating the need to bind application specific classes. 
 * Single responsibility principle
 * Open/Closed Principle - it's easy to add new types without modify existing code.