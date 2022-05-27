namespace RenderEngine;

public abstract class Controller
{
    public void Render(string viewName, object context)
    {
        var engine = CreateRenderEngine();
        engine.Render(viewName, context);
    }

    protected virtual IViewEngine CreateRenderEngine()
    {
        return new RazorViewEngine();
    }
}