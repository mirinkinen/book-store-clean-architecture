# Book store (clean architecture example)

This is an C# example of clean software architecture for purely educational
purposes. It follows the doctrine of Uncle Bob's book "Clean Architecture - A
Craftman's Guide to Software Structure and Design".

The codebase includes multiple examples of a simple book store with few use
cases. Each example has identical functionality, but the code is structured
differently to show the trade-offs they have. Each example has an README file,
which clarifies these trade-offs.

## Package by Layer

### Pros

- Easy to start with, if software architecture is not well undestood.

### Cons

- The reference between busines layer and data layer is wrong.
- Easy to misuse DI.
- Components are named by technology.
- Easy to couple different business concerns.

## Package by Feature architecture

### Pros

- Easy to start with, if software architecture is not well undestood.
- Screams something about the business context.
- All the code for the specific business context is in the same place.

### Cons

- The reference between busines layer and data layer is wrong.
- Easy to misuse DI.
- Hosting technology is coupled to the component

## Ports and Adapters architecture

### Pros

- Business layer is the heart of the application. It depends on nothing!
- Easier to hide unnecessary details from the high-level policy.

### Cons

- Needs more understanding of good software architecture.
- Easy to misuse DI.
- Components are named by technology.
- Easy to couple different business concerns. This can be mitigated by using DDD
  pattern.

# Package by Component architecture

## Pros

- Screams something about the business context.
- All the code for the specific business context is in the same place.
- Business layer is the heart of the application. It depends on nothing!
- Easier to hide unnecessary details from the high-level policy.
- Prevents clients using internal classes, even with DI.
- The component only has one public interface.

## Cons

- None :-)
