namespace SpotifyProject;

public partial class GamePage : ContentPage
{
	public string GameType { get; set; }
	
	public GamePage(string gameType)
	{
		InitializeComponent();
		
	}
}