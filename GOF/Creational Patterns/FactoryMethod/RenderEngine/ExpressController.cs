namespace RenderEngine;

public abstract class ExpressController : Controller
{
    protected override IViewEngine CreateRenderEngine()
    {
        return new ExpressViewEngine();
    }
}