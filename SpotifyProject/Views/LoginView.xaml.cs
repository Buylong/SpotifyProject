namespace SpotifyProject.Views;

public partial class LoginView
{
    private readonly LoginViewModel loginViewModel;

    public LoginView(LoginViewModel loginViewModel)
	{
		InitializeComponent();
        this.loginViewModel = loginViewModel;

        BindingContext = loginViewModel;
    }
}