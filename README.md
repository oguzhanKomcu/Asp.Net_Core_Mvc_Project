# Asp.Net Core Mvc

ASP.NET Core is an open source software development platform developed by Microsoft. Introduced in 2016, the technology is one of the best alternatives for developing ASP.NET based applications.

ASP.NET Core makes it easier for developers working with .NET technologies to develop more responsive, reliable and extensible applications. ASP.NET Core has redesigned the entire ASP.NET infrastructure and combined it with Web API and MVC infrastructures.

Creating APIs for web applications has become easier this way. Microsoft is regularly improving this platform. Thanks to ASP.NET Core technology, it is possible to create modern applications in a shorter time with less effort and cost.

# What are Asp.Net Core Features?

Among the Asp.Net Core features, its performance draws attention. Thanks to the library and auxiliary tools included, both a fast coding process and high-performance software can be produced. Easy update possibilities, fast release cycles, as well as making necessary adjustments in mobile devices provide great benefits.

Servers are needed for the resulting applications to reach people and work. Server choice is as important as software choice. The reason for this is that the software languages supported by the servers differ. Linux, Mac OSx and Windows servers all have their own features. The code languages they support also vary. Asp.Net Core is here to be admired and has a structure that can run on every operating system. Thanks to this feature, the server options are also quite wide.

### Simple Unit Testing Support
Microsoft has replaced the Visual Studio Test engine with xUnit.net in ASP.NET Core. Thanks to Dependency Injection and interfaces, ASP.NET Core has become very convenient for Unit Testing.

### Dependency Injection Support
Dependency injection is a programming technique/principle that aims to get rid of dependencies of a class/object and makes that object as independent as possible.
By applying Dependency Injection; You can ensure that a class can act independently of the object it is dependent on, and you can eliminate the need to make changes despite possible improvements to the code.

Frameworks let you deal with the business logic only, and take care of all the other operations. It usually provides dependency injection so that we can write code independent of the framework.

### What are the advantages of Dependency Injection application?

- Instead of using the dependencies directly, it is aimed to minimize the dependency in the system by exporting these objects from outside. Thus, we are protected from changes on the dependency class.
- While it simplifies the writing of unit tests, it also increases the accuracy. One of the most important issues in software development is that the components in the software are "loosely coupled". It is one of the important techniques that can provide this in Dependency Injection. Thus, independent classes can be tested on their own.

## Types of Dependency Injection

As you can see above, the injector class injects the service (dependency) into the client (dependent). The Injector class generally injects dependencies in three ways: through a constructor, through a property, or through a method.

## Constructor Injection
- In constructor injection, the injector service (dependency) is provided through the client class constructor.

## Property Injection
- In property injection (aka Setter Injection), the injector provides the dependency via a public property of the client class.

## Method Injection
- In this type of injection, the client class implements an interface that declares the method(s) to provide the dependency, and the injector uses that interface to provide the dependency to the client class.

## IoC (Inversion Of Control)

It is a software development principle that aims to create objects that are loose coupling over the life cycle of the application. It is responsible for the life cycle of objects, provides their management. When an interface is injected into the class using IoC, the corresponding interface methods become available. Thus, the class using IoC only knows the methods it will use, even if there are more methods in the class, it will be able to access the methods specified in the interface.

It enables us to develop rewritable and testable software since the class using IoC will not be affected by any changes to be made in the class. IoC object bindings are usually configured at application startup. In this sense, it is very easy to change and manage IoC configurations made from a single place.

## We can list the advantages of using IoC as follows:

- Creating loosely coupled classes
- Easy unit test writing
- Manageability
- Modular programs
- Easy transition between different implementations
