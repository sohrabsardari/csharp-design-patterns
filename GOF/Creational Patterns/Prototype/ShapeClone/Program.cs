using ShapeClone;

var circle = new Circle(radius: 1000);
circle.Render();

var contextMenu = new ContextMenu();
contextMenu.Duplicate(circle);