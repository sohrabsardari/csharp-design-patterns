public class Draft : State
{
    public override State Render()
    {
        Console.WriteLine("Render the document");
        return new Moderation();

    }
}