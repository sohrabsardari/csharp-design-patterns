namespace RenderEngine;

public class ExpressViewEngine : IViewEngine
{
    public void Render(string viewName, object context)
    {
        Console.WriteLine("Rendered by Express");
    }
}