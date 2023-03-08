# Abstract Factory Pattern

## Summary

Frameworks mostly use the abstract factory Design Pattern. In most cases, it's about creating things that you want to use together. For example, you need to use a theme for your application and you want to use kendo framework. Abstract factory provides an abstraction that you can implement it using KendoFactory. Inside of the KendoFactory you can have all the styles and widgets of the kendo in your application.

|      Title       |  Category  |     Tag      |
| :--------------: | :--------: | :----------: |
| Abstract Factory | Creational | Gang of Four |

Abstract Factory is an **Object Creational**.

There are a lot of real-world examples of the Abstract Factory pattern. It's a common design pattern for frameworks because it gives you a configurable option to add new things to your framework. In addition, it gives you an excellent extensibility point for your framework.

## Intent

Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

## Also known as

Kit

## Diagrams
![image](https://user-images.githubusercontent.com/14781288/223683003-9c8f2fb6-f9f7-48e3-9913-ffe46166f3ad.png)

## Real world example

DotNet's DbProviderFactory is a famous example of Abstract Factory. It gives you an abstraction, then you can use it for creating new factories. In Dotnet they use SqlProviderFactory that implements everything you need in your application for SQL.

## Applicability

Use the Abstract Factory pattern when

* A system should be independent of how its products are created, composed, and represented.

* A system should be configured with one of multiple families of products.

* A family of related product objects is designed to be used together, and you need to enforce this constraint.

* You want to provide a class library of products, and you want to reveal just their interfaces, not their implementations.

## Credits

Design Patterns: Elements of Reusable Object-Oriented Software
