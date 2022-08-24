using PMS.VM;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PMS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainVM mainVM = new MainVM();

            MainView mainView = new MainView();

            mainView.DataContext = mainVM;

            mainView.Show();
        }
    }
}
