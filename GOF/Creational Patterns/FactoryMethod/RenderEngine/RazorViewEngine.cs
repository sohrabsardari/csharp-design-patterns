namespace RenderEngine;

public class RazorViewEngine : IViewEngine
{
    public void Render(string viewName, object context)
    {
        Console.WriteLine("Rendered by Razor");
    }
}