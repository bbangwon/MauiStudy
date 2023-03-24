using System.ComponentModel;
using System.Globalization;

namespace MauiAppTest.TriggerDemo;

public partial class StateTriggerDemo : ContentPage
{
	public StateTriggerDemo()
	{
		InitializeComponent();
	}

    private void OnCheckedStateIsActiveChanged(object sender, EventArgs e)
    {
        StateTriggerBase stateTrigger = (StateTriggerBase)sender;
        Console.WriteLine($"Checked state active: {stateTrigger.IsActive}");
    }

    private void OnUncheckedStateIsActiveChanged(object sender, EventArgs e)
    {
        StateTriggerBase stateTrigger = (StateTriggerBase)sender;
        Console.WriteLine($"Unchecked state active: {stateTrigger.IsActive}");
    }
}

public class TriggerViewModel : INotifyPropertyChanged
{
    private bool isToggled;
    public bool IsToggled { 
        get => isToggled; 
        set
        {
            if ( isToggled != value )
            {
                isToggled = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsToggled)));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
}

public class InverseBooleanConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return !(bool)value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();        
    }
}