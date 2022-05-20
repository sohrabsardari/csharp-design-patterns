namespace ShapeClone;

public class Circle : IComponent
{
    public int Radius { get; private set; }
    public Circle(int radius)
    {
        Radius = radius;
    }

    
    public void Render()
    {
        Console.WriteLine($"Rendering a circle with radius: {Radius}....");
    }

    public IComponent Clone()
    {
        return new Circle(Radius);
    }
}