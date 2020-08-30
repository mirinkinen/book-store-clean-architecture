# Package by Layer architecture

## Pros

- Simple
- Does not need Dependency Inversion, but can use it.

## Cons

- Because WebApi layer references Business layer which references Data layer,
the data layer can be seen as the heart of the application, which is clearly
wrong, since the business layer should the heart. Everything should depend on
the business layer.
- With DI, WebApi layer can easily use Data layer directly by injecting
  IBookRepository. This should be prevented.
