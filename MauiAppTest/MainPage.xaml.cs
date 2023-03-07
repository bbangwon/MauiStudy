namespace MauiAppTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		lblGesture.Text = "1234";
        EventButton.Clicked += EventButton_Clicked;
	}

    private void EventButton_Clicked(object sender, EventArgs e)
    {
        lblGesture.Text = $"Event Button Clicked";
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		++count;
		lblGesture.Text = $"{count}";

		var lblSender = sender as Label;

		if(count % 2 == 0) 
			lblSender.TextColor = Colors.Blue;
		else
			lblSender.TextColor = Colors.Red;
    }
}

