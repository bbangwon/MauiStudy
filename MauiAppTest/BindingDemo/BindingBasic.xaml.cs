namespace MauiAppTest.BindingDemo;

public partial class BindingBasic : ContentPage
{
	public BindingBasic()
	{
		InitializeComponent();
        InitBindings();
    }

    private void InitBindings()
    {
        //slider의 Value가 변경되면 Label.RotationProperty로 값이 이동
        label_0.BindingContext = slider;
		label_0.SetBinding(Label.RotationProperty, "Value");

        label_2.SetBinding(Label.RotationProperty, new Binding("Value", source: slider));
    }
}