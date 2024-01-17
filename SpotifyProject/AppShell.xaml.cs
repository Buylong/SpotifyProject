namespace SpotifyProject;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(mathgamepage), typeof(mathgamepage));
	}
}
