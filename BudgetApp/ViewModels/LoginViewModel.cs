using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BudgetApp.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty] private string _username = string.Empty;
    [ObservableProperty] private string _password = string.Empty;

    [RelayCommand]
    private void Login()
    {
        
    }
}