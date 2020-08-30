# Ports and Adapters architecture

## Pros

- Business layer is the heart of the application. It depends on nothing!
- Easier to hide unnecessary details from the high-level policy
- With DI, its easy to change implementations.

## Cons

- Slightly harder to understand as it needs DI to work. 
