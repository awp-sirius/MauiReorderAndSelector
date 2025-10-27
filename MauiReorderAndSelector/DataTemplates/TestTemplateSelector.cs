namespace MauiReorderAndSelector.DataTemplates;

public class TestTemplateSelector : DataTemplateSelector
{
    private static readonly DataTemplate EmptyTemplate = new DataTemplate(() => new ContentView());

    public DataTemplate? GreenTemplate { get; set; }
    public DataTemplate? BlueTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        return (int)item % 2 == 0
            ? GreenTemplate ?? EmptyTemplate
            : BlueTemplate ?? EmptyTemplate;
    }
}