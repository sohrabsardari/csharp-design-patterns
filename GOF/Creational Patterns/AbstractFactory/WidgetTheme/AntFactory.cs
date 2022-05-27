namespace WidgetTheme;

public class AntFactory : IWidgetFactory
{
    public IButton CreateButton()
    {
        return new AntButton();
    }

    public ITextBox CreateTextBox()
    {
        return new AntTextBox();
    }
}