namespace MauiAppTest.TriggerDemo;

public partial class TriggerDemo : ContentPage
{
	public TriggerDemo()
	{
		InitializeComponent();
	}
}

public class NumericValidationTriggerAction : TriggerAction<Entry>
{
    protected override void Invoke(Entry entry)
    {
        bool isValid = double.TryParse(entry.Text, out _);
        entry.TextColor = isValid ? Colors.Blue : Colors.Red;
    }
}