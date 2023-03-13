namespace MauiAppTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(StackLayoutDemo), typeof(StackLayoutDemo));

		MainPage = new AppShell();
	}
}
