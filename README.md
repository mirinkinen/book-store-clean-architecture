# Book store (clean architecture example)

This is an C# example of clean software architecture for purely educational
purposes. It follows the doctrine of Uncle Bob's book "Clean Architecture - A
Craftman's Guide to Software Structure and Design".

The example application is in a form of a book store. The point of this example
is to learn software architecture, code structure and design principles that are
found in the Uncle Bob's book. Because of this, the code includes many
abstractions, more than may be practical in a real-life application.

## Design principles

Some of the used design principles used are:

- Screaming architecture: it should be quite obvious which part does what, when
  looking at the code and component structure.
- Abstractions: all details are behind abstractions and should be exchangeable
  for another implementation of the same abstraction.

## Code documentation

The code is documented to explicitly point out the design principle behind it.
Since there always are many ways to design things, some design decisions may
feel exaggeration. Remember, this is just an example for educational purposes.

## Hosting Environments

The application can be launched as an ASP.NET Core or .NET Core console
application to prove, that the implementation is not bound to any hosting
technology and can be run in different environments.
