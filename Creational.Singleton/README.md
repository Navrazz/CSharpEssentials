## Singleton resticts the instantiation of the class to single instance

### Components:
 * Singleton is a class which defines exactly one instance of itself and that instance is globally accessible.
   
### Advantages:
 * You can be sure that class has only one instance
 * Global access point to that instance

### Disadvantages:
 * Violates the Single Responsibility Principle. This pattern solves at least two problems at the time
 * Singleton requires special treatment in multithreaded enviroment
 * It may be difficult to unit test the client code