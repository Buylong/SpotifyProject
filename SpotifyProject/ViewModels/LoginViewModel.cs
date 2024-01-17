
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace SpotifyProject.ViewModels
{
    public partial class LoginViewModel : ViewModel
    {


        public LoginViewModel() { }


        [ObservableProperty]
        private bool showLogin;

        [ObservableProperty]
        private bool showMathGame;


        [RelayCommand]
        private void OpenLogin()
        {
            ShowLogin = true;
        }
        
       
      
    }

}
