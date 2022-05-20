namespace ShapeClone;

public class ContextMenu
{
    public void Duplicate(IComponent component)
    {
        var newComponent = component.Clone();

        newComponent.Render();
        Console.WriteLine("added new shape to our page");
    }
}