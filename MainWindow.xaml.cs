using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pacientes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CommandManager commandManager;

        public MainWindow(CommandManager commandManager)
        {
            this.commandManager = commandManager;
            InitializeComponent();
        }

        private void NewPacientClicked(object sender, RoutedEventArgs e)
        {
            this.commandManager.ActivateCommand(typeof(CommandNewPacient).Name);
        }
    }
}
