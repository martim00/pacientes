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

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            commandManager.AddCommand(new CommandNewPacient());

            MainWindow mw = new MainWindow(commandManager);
            mw.Show();
        }
    }
}
