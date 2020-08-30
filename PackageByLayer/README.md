# Package by Layer architecture

## Pros

- Simple
- Does not need Dependency Inversion, but can use it.

## Cons

- In this example, WebApi layer references Application layer, which references
  Business layer which references Data layer. Therefore, the data layer can be
  seen as the heart of the application, which is clearly wrong, since the business
  layer should the heart. Everything should depend on the business layer and it
  should not depend on anything.
- With DI, WebApi layer can easily use Data layer directly by injecting
  IBookRepository. This is a violatin of this architecture and should be
  prevented somehow.
