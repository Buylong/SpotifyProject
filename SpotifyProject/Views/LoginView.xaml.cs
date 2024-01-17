using System.Net;

namespace SpotifyProject.Views;

public partial class LoginView
{
    private readonly LoginViewModel loginViewModel;

    private readonly string state;

    public LoginView(LoginViewModel loginViewModel)
	{
		InitializeComponent();
        this.loginViewModel = loginViewModel;

        BindingContext = loginViewModel;

        state = Guid.NewGuid().ToString();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        loginViewModel.PropertyChanged += LoginViewModel_PropertyChanged;
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        loginViewModel.PropertyChanged -= LoginViewModel_PropertyChanged;
    }
    private void LoginViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if(e.PropertyName == nameof(loginViewModel.ShowLogin))
        {
            var scopes = "playlist-read-private playlist-modify-private";

            var querystring = $"response_type=code&client_id={Constants.SpotifyClientId}&scopes={WebUtility.UrlEncode(scopes)}&redirect_uri={Constants.RedirectUrl}&state={state}";

            LoginWeb.Source = $"https://accounts.spotify.com/authorize?{querystring}";

           // LoginWeb.Navigating += LoginWeb_Navigating;

            Login.TranslationY = this.Height;
            Login.IsVisible = true;

            Login.TranslateTo(Login.X, 100, easing: Easing.Linear);
        }
    }
    private void mathgamebutton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(mathgamepage));

    }

 
}