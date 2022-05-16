namespace CompositeBaseExample;

public sealed class Leaf : Component
{
    public override void Operation()
    {
        Console.WriteLine("Leaf Operation");
    }

    public override bool IsComposite()
    {
        return false;
    }
}