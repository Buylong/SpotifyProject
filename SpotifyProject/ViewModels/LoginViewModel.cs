using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SpotifyProject.ViewModels
{
    public partial class LoginViewModel : ViewModel
    {
    }

    public LoginViewModel() { }


    [ObservableProperty]
    private bool showLogin;


    [RelayCommand]
private void OpenLogin()
    {
        ShowLogin = true;
    }
}
