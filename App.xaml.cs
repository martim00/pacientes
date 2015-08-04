using pacientes.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace pacientes
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private CommandManager commandManager = new CommandManager();
        private DbService dbService = new DbService();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            dbService.Init();

            commandManager.AddCommand(new CommandNewPacient(dbService));

            MainWindowViewModel viewModel = new MainWindowViewModel(commandManager, dbService);

            MainWindow mw = new MainWindow(viewModel);
            mw.Show();
        }
    }
}
