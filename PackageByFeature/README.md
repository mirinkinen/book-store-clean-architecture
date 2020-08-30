# Package by Feature architecture

## Pros

- Easy to understand
- Does not need Dependency Inversion, but can use it.
- Screams something about the context.
- All the code for the context is in the same place.

## Cons

- The reference between busines layer and data layer is wrong.
- Its easy to use class from layers that should not be used.