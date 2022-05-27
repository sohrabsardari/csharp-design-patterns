namespace RenderEngine;

public class SomeOtherViewEngineController : ExpressController
{
    public void GetListOfViews()
    {
        var context = new object();
        base.Render("ListOfViews.html", context);
    }
}