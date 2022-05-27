namespace WidgetTheme;

public class ContactForm
{
    public void Render(IWidgetFactory factory)
    {
        factory.CreateButton().Render();
        factory.CreateTextBox().Render();
    }
}