namespace MauiAppTest;

public partial class StaticResourceDemo : ContentPage
{
	public StaticResourceDemo()
	{
		InitializeComponent();
	}

    private async void GotoCustom(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SharedResourceDemo));
    }

    private void OnLight(object sender, EventArgs e)
    {
        /*
        LayoutRoot.Background = Colors.Silver;

        tipLabel.TextColor = Colors.Navy;
        billLabel.TextColor = Colors.Navy;
        totalLabel.TextColor = Colors.Navy;
        tipOutput.TextColor = Colors.Navy;
        totalOutput.TextColor = Colors.Navy;
        */

        //Dynamic Resources
        Resources["fgColor"] = Colors.Navy;
        Resources["bgColor"] = Colors.Silver;
    }
    private void OnDark(object sender, EventArgs e)
    {
        /*
        LayoutRoot.Background = Colors.Navy;

        tipLabel.TextColor = Colors.Silver;
        billLabel.TextColor = Colors.Silver;
        totalLabel.TextColor = Colors.Silver;
        tipOutput.TextColor = Colors.Silver;
        totalOutput.TextColor = Colors.Silver;
        */

        Resources["fgColor"] = Colors.Silver;
        Resources["bgColor"] = Colors.Navy;
    }

}