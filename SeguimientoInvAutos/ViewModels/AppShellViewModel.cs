using Microsoft.Toolkit.Mvvm.Input;
using SeguimientoInvAutos.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoInvAutos.ViewModels
{
    public partial class AppShellViewModel :BaseViewModel
    {
        [ICommand]
        async void Salir()
        {
            if(Preferences.ContainsKey(nameof(App.UserInfo)))
            {
                Preferences.Remove(nameof(App.UserInfo));
            }
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

    }
}
