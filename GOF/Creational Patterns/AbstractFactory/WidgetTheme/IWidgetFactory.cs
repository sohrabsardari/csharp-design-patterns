namespace WidgetTheme;

public interface IWidgetFactory
{
    public IButton CreateButton();
    public ITextBox CreateTextBox();
}