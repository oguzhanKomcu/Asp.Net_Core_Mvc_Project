# Asp.Net Core 

ASP.NET Core is an open source software development platform developed by Microsoft. Introduced in 2016, the technology is one of the best alternatives for developing ASP.NET based applications.

ASP.NET Core makes it easier for developers working with .NET technologies to develop more responsive, reliable and extensible applications. ASP.NET Core has redesigned the entire ASP.NET infrastructure and combined it with Web API and MVC infrastructures.

Creating APIs for web applications has become easier this way. Microsoft is regularly improving this platform. Thanks to ASP.NET Core technology, it is possible to create modern applications in a shorter time with less effort and cost.

# What are Asp.Net Core Features?

<img src="https://user-images.githubusercontent.com/96787308/160295642-fe61dacc-46c2-4a58-80bf-081a1caac360.png" width="800" height="400">



Among the Asp.Net Core features, its performance draws attention. Thanks to the library and auxiliary tools included, both a fast coding process and high-performance software can be produced. Easy update possibilities, fast release cycles, as well as making necessary adjustments in mobile devices provide great benefits.

Servers are needed for the resulting applications to reach people and work. Server choice is as important as software choice. The reason for this is that the software languages supported by the servers differ. Linux, Mac OSx and Windows servers all have their own features. The code languages they support also vary. Asp.Net Core is here to be admired and has a structure that can run on every operating system. Thanks to this feature, the server options are also quite wide.

### Simple Unit Testing Support
Microsoft has replaced the Visual Studio Test engine with xUnit.net in ASP.NET Core. Thanks to Dependency Injection and interfaces, ASP.NET Core has become very convenient for Unit Testing.

### Dependency Injection Support

<img src="https://user-images.githubusercontent.com/96787308/160295457-07ebc1c4-a660-4776-9a62-424a5ffa8e73.png" width="1000" height="600">

Dependency injection is a programming technique/principle that aims to get rid of dependencies of a class/object and makes that object as independent as possible.
By applying Dependency Injection; You can ensure that a class can act independently of the object it is dependent on, and you can eliminate the need to make changes despite possible improvements to the code.

Frameworks let you deal with the business logic only, and take care of all the other operations. It usually provides dependency injection so that we can write code independent of the framework.

You can see about it here. [GitHub Pages](https://github.com/oguzhanKomcu/Asp.Net_Core_Mvc_Project/tree/master/Hospital_Appointment_System_MVC_Project/Infrastructure/EntityTypeConfiguration/Repositories)


### What are the advantages of Dependency Injection application?

- Instead of using the dependencies directly, it is aimed to minimize the dependency in the system by exporting these objects from outside. Thus, we are protected from changes on the dependency class.
- While it simplifies the writing of unit tests, it also increases the accuracy. One of the most important issues in software development is that the components in the software are "loosely coupled". It is one of the important techniques that can provide this in Dependency Injection. Thus, independent classes can be tested on their own.

## Types of Dependency Injection

As you can see above, the injector class injects the service (dependency) into the client (dependent). The Injector class generally injects dependencies in three ways: through a constructor, through a property, or through a method.

### Constructor Injection
- In constructor injection, the injector service (dependency) is provided through the client class constructor.

### Property Injection
- In property injection (aka Setter Injection), the injector provides the dependency via a public property of the client class.

### Method Injection
- In this type of injection, the client class implements an interface that declares the method(s) to provide the dependency, and the injector uses that interface to provide the dependency to the client class.

## IoC (Inversion Of Control)

<img src="https://miro.medium.com/max/1400/0*xHbH1PyWuhPmGB4J.png" width="1000" height="600">


It is a software development principle that aims to create objects that are loose coupling over the life cycle of the application. It is responsible for the life cycle of objects, provides their management. When an interface is injected into the class using IoC, the corresponding interface methods become available. Thus, the class using IoC only knows the methods it will use, even if there are more methods in the class, it will be able to access the methods specified in the interface.

It enables us to develop rewritable and testable software since the class using IoC will not be affected by any changes to be made in the class. IoC object bindings are usually configured at application startup. In this sense, it is very easy to change and manage IoC configurations made from a single place.

## We can list the advantages of using IoC as follows:

- Creating loosely coupled classes
- Easy unit test writing
- Manageability
- Modular programs
- Easy transition between different implementations

You can see about it here. [GitHub Pages](https://github.com/oguzhanKomcu/Asp.Net_Core_Mvc_Project/blob/master/Hospital_Appointment_System_MVC_Project/Program.cs)

## There are 3 service life time managers in Asp .Net Core.

### Transient
 When we register a type as Transient, a new instance is created each time. Transient creates a new instance for each service/controller and each request and each user. This method creates a Transient service. A new instance of the Transient service is created each time it is requested. For example: suppose a request is made temporarily to a web api controller method 'categorycontroller' then a unique id will be assigned to the request, now from within this controller the request is redirected to another controller method for further execution then the same request id will be replaced with a new request id. For example, when the same request is routed to another controller method, the ID of the request will remain the same. But at the same time, if another request is made to the controller, then a new ID will be assigned.

### Singleton
 When we register a type as a singleton, only one instance can be used throughout the application and per request. It's similar to having a static object. The instance is created for the first request and the same state can be used throughout the application and for every subsequent request. A Singleton service is created only once per application and this single instance is used for the lifetime of the application. As the name suggests, the AddSingleton() method creates a Singleton service. A Singleton service is created when first requested. This same instance is then used by all subsequent requests. For example, the identity is the same for everyone, no matter how many new redirects are made within the application or new requests are made to the application.

### Scoped
 A new instance is created for each service scope. These services behave like singletons within the scope of service. If the service is purgeable, it is automatically cleared when the service coverage expires and is eliminated. For example, in a web application it creates 1 instance for each http request, but uses the same instance for other calls within the same web request.
 
## Enhanced Coding Efficiency with Razor Pages

ASP.NET Core, Razor Pages is a lightweight and flexible page-oriented framework for building dynamic and data-driven applications. It offers developers full control over HTML.

You don't need to have MVC knowledge to use Razor Pages. This infrastructure is very similar to MVVM (Model-View-ViewModel) models and provides a simpler development experience by isolating the responsibilities of each component. Razor Pages is ideal for simple applications that do basic data entry.

You can see about it here. [GitHub Pages](https://github.com/oguzhanKomcu/Asp.Net_Core_Mvc_Project/blob/master/Hospital_Appointment_System_MVC_Project/Views/Patient/Details.cshtml)

## Simple Coding Components

HTML is considered the most preferred language for creating various web pages. Along with HTML, CSS and JavaScript are used on a very large scale. You can use HTML elements to create user interfaces with Tag Helper in ASP.NET Core. This allows you to get very successful interfaces with a very simple coding.  

You can see about it here. [GitHub Pages](https://github.com/oguzhanKomcu/Asp.Net_Core_Mvc_Project/blob/master/Hospital_Appointment_System_MVC_Project/Views/Patient/Create.cshtml)

