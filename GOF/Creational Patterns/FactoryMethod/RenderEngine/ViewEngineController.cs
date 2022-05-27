namespace RenderEngine;

public class ViewEngineController : Controller
{
    public void GetListOfViews()
    {
        var context = new object();
        base.Render("ListOfViews.html", context);
    }
}