namespace MauiAppTest;

public partial class ClickMe : ContentPage
{
	public ClickMe()
	{
		InitializeComponent();
	}

	private int count;

	private void OnCountClicked(object sender, EventArgs args)
	{
		count++;

		if(count == 1)
		{
			CounterBtn.Text = $"Clicked {count} time";
		}
		else
		{
			CounterBtn.Text = $"Clicked {count} times";
		}

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}