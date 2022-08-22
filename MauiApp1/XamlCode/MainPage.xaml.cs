using System.Diagnostics;

namespace MauiApp1.XamlCode;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        Debug.WriteLine("Clicked !");
    }
}