using System.Windows;
using BudgetApp.Data;
using BudgetApp.ViewModels;
using BudgetApp.Views;
using Microsoft.Extensions.DependencyInjection;

namespace BudgetApp;


public partial class App : Application
{
    private ServiceProvider _serviceProvider;

    public App()
    {
        var services = new ServiceCollection();

  
        services.AddDbContext<AppDbContext>();
        services.AddScoped<LoginViewModel>();
        services.AddScoped<LoginView>();
        _serviceProvider = services.BuildServiceProvider();
        
        
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        using var scope = _serviceProvider.CreateScope();
        var loginWindow = scope.ServiceProvider.GetRequiredService<LoginView>();
        loginWindow.Show();
    }

}