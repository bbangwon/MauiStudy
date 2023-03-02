namespace MauiAppTest;

public partial class TestPage : ContentPage
{
	public TestPage()
	{
		InitializeComponent();
	}

	int count = 0;

    private void Button_Clicked(object sender, EventArgs e)
    {
		count++;
		CounterLabel.Text = $"Current count: {count}";
		SemanticScreenReader.Announce(CounterLabel.Text);
    }
}