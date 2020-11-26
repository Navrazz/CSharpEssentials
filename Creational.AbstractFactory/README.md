## Define an interface or abstract class for creating families of related (or dependent) objects but without specifying their concrete sub-classes.
## Abstract Factory lets a class returns a factory of classes. So, this is the reason that Abstract Factory Pattern is one level higher than the Factory Pattern.

### Components:
  * The AbstractFactory declares an interface for operations which will create AbstractProduct objects.
  * The ConcreteFactory objects implement the operations defined by the AbstractFactory.
  * The AbstractProduct declares an interface for a type of product.
  * The Products define a product object that will be created by the corresponding ConcreteFactory.
  * The Client uses the AbstractFactory and AbstractProduct interfaces.
  
### Advantages:
  * Products from factory are compatible with each other
  * Loose coupling
  * Single Responsibility Principle
  * Open/Closed Principle
