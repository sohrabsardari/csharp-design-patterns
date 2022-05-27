namespace WidgetTheme;

public class MaterialFactory : IWidgetFactory
{
    public IButton CreateButton()
    {
        return new MaterialButton();
    }

    public ITextBox CreateTextBox()
    {
        return new MaterialTextBox();
    }
}