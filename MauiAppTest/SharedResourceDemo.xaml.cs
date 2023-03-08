using System.Diagnostics;

namespace MauiAppTest;

public partial class SharedResourceDemo : ContentPage
{
	public SharedResourceDemo()
	{
		InitializeComponent();
	}

    private void OnSaveButtonClicked(object sender, EventArgs e)
    {
        Debug.WriteLine("OnSaveButtonClicked");
    }

    private void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        Debug.WriteLine("OnDeleteButtonClicked");
    }
}