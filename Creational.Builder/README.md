## Create objects with several parts but not all parts have to be in specific object. 

### Components:
 * The Builder defines the interface for creating parts of a Product (Article in this case)
 * The ConcreteBuilder constructs parts of the product (implementing Builder interface). It also define object it creates
 * The Product (Article) is object we're creating
 * The Director constructs an object. We can also skip director to create Product.

### Advantages:
 * Reusable - we can use the same code to building various products
 * Single responsibility principle