namespace RenderEngine;

public interface IViewEngine
{
    void Render(string viewName, object context);
}