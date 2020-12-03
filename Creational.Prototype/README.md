## Copy existing objects with no dependency of their classes

### Components:
 * The Prototype (ICloneable) declares an interface to cloning itself - in C# we can use Clonable interface out of the box
 * ConcretePrototype (User class) implements cloning funcionality defined by interface
 * Client creates a new object by using one of the cloning methods
   
### Advantages:
 * Loose coupling - clone objects without coupling it to their concrete classes
 * Creating complex objects easly
