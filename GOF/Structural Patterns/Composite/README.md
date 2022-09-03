# Composite Pattern

## Summary

|   Title   |  Category  |     Tag      |
| :-------: | :--------: | :----------: |
| Composite | Structural | Gang of Four |

Composite Pattern is an **object structural pattern**.

## Intent

Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.  

## Diagrams

![image](https://user-images.githubusercontent.com/14781288/188286313-e14f7fee-32e3-4e5d-ba0e-622874ed5ab7.png)

## Real world example

### File system in operating systems.

Did you see your computer folder structures? In computers there are two main type of structure for storing data structures. **Files and Folders (Directory)**. So, you can have many folders in one of your drives and inside of that folder, you can have many folders and files. When you delete one of the folders, all of file and folders inside it will be deleted. This is **Composite Pattern**. 

## Applicability

Use the Composite pattern when

-  you want to represent part-whole hierarchies of objects.
-  you want clients to be able to ignore the difference between compositions of objects and individual objects. Clients will treat all objects in the composite structure uniformly.  

## Credits

- Design Patterns: Elements of Reusable Object-Oriented Software
