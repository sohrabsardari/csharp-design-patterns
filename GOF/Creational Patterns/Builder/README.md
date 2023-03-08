# Builder Pattern

## Summary

|  Title  |  Category  |     Tag      |
| :-----: | :--------: | :----------: |
| Builder | Creational | Gang of Four |

Builder is an **Object Creational**.

There are a lot of real-world examples of the Builder pattern, and it is used frequently by people. You can find lots of real world code that uses builders.

## Intent

Separate the construction of a complex object from its representation so that the same construction process can create different representations.    

## Diagrams
![image](https://user-images.githubusercontent.com/14781288/222767298-d3be175f-9da8-462c-a07f-83a53083758d.png)

## Real world example

Builders can be implemented in two ways: with director and without it.

There is a package in Dotnet named **FluentMigrator** that uses builder to write database migration which is very fun. It uses fluent builder without director and the code is as follows:

```c#
Create.Table("Log")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Text").AsString();
```

## Applicability

You can use the builder to create complex objects and you want them to be independent of how they are assembled.

Also, you can use the builder when you want to have different representations of an object and you want to encapsulate the construction process from those representations.

## Credits

- Design Patterns: Elements of Reusable Object-Oriented Software
