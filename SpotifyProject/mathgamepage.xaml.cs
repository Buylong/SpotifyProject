namespace SpotifyProject;

public partial class mathgamepage : ContentPage
{
	public mathgamepage()
	{
		InitializeComponent();
	}

    public mathgamepage(string text)
    {
    }

    private void OnGameChosen(object sender, EventArgs e)
    {
		Button button = (Button)sender;

		Navigation.PushAsync(new mathgamepage(button.Text));
    }
	
	private void OnViewPreviousGameChosen(object sender, EventArgs e)
    {
		Button button = (Button)sender;

		Navigation.PushAsync(new PreviousGames(button.Text));
    }
}