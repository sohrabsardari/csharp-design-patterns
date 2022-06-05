public class Moderation : State
{
    public override State Publish()
    {
        Console.WriteLine("Publish the document");
        return new Published();
    }
}