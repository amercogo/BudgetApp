using System.Windows;
using BudgetApp.ViewModels;

namespace BudgetApp.Views;

public partial class LoginView : Window
{
    public LoginView(LoginViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}