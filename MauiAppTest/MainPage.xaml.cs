namespace MauiAppTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		++count;

		var lblSender = sender as Label;

		if(count % 2 == 0) 
			lblSender.TextColor = Colors.Blue;
		else
			lblSender.TextColor = Colors.Red;
    }
}

