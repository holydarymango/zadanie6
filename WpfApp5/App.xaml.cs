using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WpfApp5.Model;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade facade = new DatabaseFacade(new ModelContext());
            facade.EnsureCreated();
        }
    }

}
