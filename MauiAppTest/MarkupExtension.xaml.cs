namespace MauiAppTest;

public partial class MarkupExtension : ContentPage
{
    public const double MyFontSize = 20;
	public MarkupExtension()
	{
		InitializeComponent();
	}
}

public class GlobalFontSizeExtension : IMarkupExtension
{
    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return MarkupExtension.MyFontSize;
    }
}