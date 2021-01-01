## Adapting two interfaces within one funcionality when at least one interface can't be rafactored. Adapter pattern allows to create middle layer class that is kind of translator between new code and legacy code (kind of wrapper).

### Components:
 * The Target
 * The Client
 * The Adapter
 * The Adaptee
   
### Advantages:
 * Single responsibility principle - separate interface from primary business logic
 * Open/Closed principle - adding new types of adapters without changing existing code