
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace SpotifyProject.ViewModels
{
    public partial class LoginViewModel : ViewModel
    {


        public LoginViewModel() { }


        [ObservableProperty]
        private bool showLogin;

   


        [RelayCommand]
        private void OpenLogin()
        {
            ShowLogin = true;
        }
        
       
      
    }

}
