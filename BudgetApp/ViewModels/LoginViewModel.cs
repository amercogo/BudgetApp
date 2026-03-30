using System.Windows;
using BudgetApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BudgetApp.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    private readonly KorisnikService _korisnikService;

    public LoginViewModel(KorisnikService korisnikService)
    {
        _korisnikService = korisnikService;
    }

    [ObservableProperty] private string _username = string.Empty;
    [ObservableProperty] private string _password = string.Empty;

    [RelayCommand]
    private async Task Login()
    {
        var uspjelo = await _korisnikService.Login(_username, _password);

        if (uspjelo)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Application.Current.Windows[0].Close();
        }
        else
        {
            MessageBox.Show("Neispravno korisničko ime ili lozinka.",
                "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}